using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandBox
{
    public partial class findFigure : Form
    {
        public findFigure()
        {
            InitializeComponent();
        }

        private void btn_search_fig_Click(object sender, EventArgs e)
        {
            /*
            // throw new System.NotImplementedException();
            //creates the dataAdapter with the correct sql command
            DataSet ds = new DataSet();
            var adpt = new SQLiteDataAdapter(@"SELECT FIG_NUM,SYMBOL FROM TB_FIGURE", @"Data Source=C:\Users\sno\Documents\sandBox_db.db");
            adpt.Fill(ds);

            DataTable dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    listView1.Items.Add(row[column]);
                }
            }
             * */
            DataSet ds = DBFactory.ExcuteQuery(@"SELECT FIG_NUM,SYMBOL FROM TB_FIGURE");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                listView1.Items.Add(utfEncoding.FromUtf8((string)row[1]));
            }
        }

        private void btn_select_fig_Click(object sender, EventArgs e){
            //tb_search_fig = listView1;

            //선택된 listView1값 리턴해서 화면에 figure정보 화면에 뿌려주기
        }
    }
}
