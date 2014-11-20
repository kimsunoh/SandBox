using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SandBox
{
    public partial class SandBox : Form
    {
        public SandBox()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (Login(tb_id.Text, tb_pw.Text))
            {
                sandBoxMain sbm = new sandBoxMain();
                sbm.Show();
                this.Visible = false;

                sbm.FormClosed += new FormClosedEventHandler(OnSubFormClosed);
            }
            else
            {
                MessageBox.Show("Login failed.");
            }
        }

        private void OnSubFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private bool Login(string id, string pw)
        {
            DataSet ds = 
                DBFactory.ExcuteQuery(
                    @"SELECT * "
                  + @"  FROM TB_CURER "
                  + @" WHERE 1=1 "
                  + @"   AND CURER_ID  = '" + id + "'"
                  + @"   AND CURER_PW  = '" + pw + "'"
                );
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Console.WriteLine(" Login... - id : " + ds.Tables[0].Rows[0][0]);
                Session.curSession = new Session();
                Session.curSession.id = id;
                return true;
            }
            return false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string connStr = @"Data Source=C:\Users\sno\Documents\sandBox_db.db";
            string query = @"SELECT * FROM TEST";

            // insert, update... so on
            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO TEST VALUES (1, 'a')", conn);
                cmd.ExecuteNonQuery();

                cmd.CommandText = @"INSERT INTO TEST VALUES (2, 'b')";
                cmd.ExecuteNonQuery();
            }


            #region SQLiteDataReader
            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr["NO"]);
                }
                rdr.Close();
            }
            #endregion

            #region SQLiteDataReader
            DataSet ds = new DataSet();
            var adpt = new SQLiteDataAdapter(query, connStr);
            adpt.Fill(ds);
            Console.WriteLine("" + ds.Tables[0].Rows[1][1].ToString());
            Console.WriteLine("aaaaa");
            #endregion

            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM TEST WHERE 1=1", conn);
                cmd.ExecuteNonQuery();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBFactory.ExcuteNonQuery("INSERT INTO TB_CURER VALUES (1, 'test', 'test')");
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            if (Signup(tb_id.Text, tb_pw.Text))
            {
                MessageBox.Show("Done.");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private bool Signup(string id, string pw)
        {
            DataSet ds =
                DBFactory.ExcuteQuery(
                    @"SELECT * "
                  + @"  FROM TB_CURER "
                  + @" WHERE 1=1 "
                  + @"   AND CURER_ID  = '" + id + "'"
                );
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Console.WriteLine(" id  : " + ds.Tables[0].Rows[0][0]);
                return false;
            }
            else
            {
                DBFactory.ExcuteNonQuery(
                        @"INSERT INTO "
                      + @"       TB_CURER (CURER_ID, CURER_PW) "
                      + @"VALUES "
                      + @"   ('" + id + "', '" + pw + "')"
                    );
                return true;
            }
        }

    }
}
