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
        public event toForm1 toform1; //이벤트 등록

        private List<string> fignumList;
        public findFigure()
        {
            InitializeComponent();
        }

        private void btn_search_fig_Click(object sender, EventArgs e)
        {
            DataSet ds = DBFactory.ExcuteQuery(@"SELECT FIG_NUM,SYMBOL FROM TB_FIGURE");
            /*
             *  DataSet ds = DBFactory.ExcuteQuery(@"SELECT FIG_NUM,SYMBOL FROM TB_FIGURE WHERE "
                        + "CATEGORY = '" + utfEncoding.ToUtf8(comboBox_finfig_cate.Text) + "','"
                        + "OR DIVISION = '" + utfEncoding.ToUtf8(comboBox_finfig_div.Text) + "','"
                        + "OR SELECTION = '" + utfEncoding.ToUtf8(comboBox_finfig_sec.Text) + "')"
            );
             * 
             * **/
            //쿼리문 중복 바꿀 것
            fignumList = new List<string>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                listView1.Items.Add(utfEncoding.FromUtf8(row[1].ToString()));
                fignumList.Add(row[0].ToString());

            }
        }

        private void btn_select_fig_Click(object sender, EventArgs e){
            int idx = listView1.SelectedIndices[0];
            if (idx >= 0)
            {
                String text = fignumList[idx];
                toform1(text);
                //Application.OpenForms["findFigure"].Close();
            }
            Close();
        }

        private void findFigure_Load(object sender, EventArgs e)
        {

        }
    }
}
