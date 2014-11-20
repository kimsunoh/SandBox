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
    public delegate void toForm1(string fignum);	//델리게이트 선언

    public partial class findFigure : Form
    {
        public static event toForm1 toform1; //이벤트 등록
        public findFigure()
        {
            InitializeComponent();

        }

        private void btn_search_fig_Click(object sender, EventArgs e)
        {
            DataSet ds = DBFactory.ExcuteQuery(@"SELECT FIG_NUM,SYMBOL FROM TB_FIGURE");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                listView1.Items.Add(utfEncoding.FromUtf8((string)row[1]));
            }
        }

        private void btn_select_fig_Click(object sender, EventArgs e){
            int intselectedindex = listView1.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                String text = listView1.Items[intselectedindex].ToString();
                toform1(text);
                Application.OpenForms["findFigure"].Close();
            } 
            
        }
    }
}
