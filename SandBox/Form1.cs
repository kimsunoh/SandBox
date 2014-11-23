using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandBox
{
    public delegate void toForm2(string patnum);    //델리게이트 선언
    public partial class search_Patient : Form
    {
        public static event toForm2 toform2; //이벤트 등록

        private List<string> patnumList;
        public search_Patient()
        {
            InitializeComponent();
        }

        private void btn_search_pat_Click(object sender, EventArgs e)
        {
            DataSet ds = DBFactory.ExcuteQuery(@"SELECT PAT_NUM,PAT_NAME FROM TB_PATIENT");

            //쿼리문 중복 바꿀 것
            patnumList = new List<string>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                patListview.Items.Add(utfEncoding.FromUtf8(row[1].ToString()));
                patnumList.Add(row[0].ToString());
            }
        }
        private void btn_select_pat_Click(object sender, EventArgs e)
        {
            int idx = patListview.SelectedIndices[0];
            if (idx >= 0)
            {
                String text = patnumList[idx];
                toform2(text);
                //Application.OpenForms["search_Patient"].Close();
            }
            Close();
        }
    }
}
