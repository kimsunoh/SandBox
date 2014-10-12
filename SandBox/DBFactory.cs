using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    class DBFactory
    {
        public readonly static string connStr = @"Data Source=C:\Users\sno\Documents\sandBox_db.db";
       
        public static DataSet ExcuteQuery(string query)
        {
            try
            {
                DataSet ds = new DataSet();
                var adpt = new SQLiteDataAdapter(query, connStr);
                adpt.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void ExcuteNonQuery(string query)
        {
            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public static void testDBConnection()
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
    }
}
