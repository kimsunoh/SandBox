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
    public partial class Add_Sandbox : Form
    {

        private String fiFigNum;
        private String laFigNum;

        public Add_Sandbox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_sb_Click(object sender, EventArgs e)
        {
            //1)데이터베이스 INSERT
            //2)얼굴검출 알고리즘 Haar
        }

        private void pictureBox_lt_ph_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_lt_ph.Image = new Bitmap(ofd.FileName);
                pictureBox_lt_ph.Tag = ofd.FileName;
                String pictureBox_lt_ph_path = ofd.FileName;
            }
        }

        private void pictureBox_lb_ph_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_lb_ph.Image = new Bitmap(ofd.FileName);
                pictureBox_lb_ph.Tag = ofd.FileName;
                String pictureBox_lb_ph_path = ofd.FileName;
            }
        }

        private void pictureBox_rt_ph_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_rt_ph.Image = new Bitmap(ofd.FileName);
                pictureBox_rt_ph.Tag = ofd.FileName;
                String pictureBox_rt_ph_path = ofd.FileName;
            }
        }

        private void pictureBox_rb_ph_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_rb_ph.Image = new Bitmap(ofd.FileName);
                pictureBox_rb_ph.Tag = ofd.FileName;
                String pictureBox_rb_ph_path = ofd.FileName;
            }
        }

        private void pictureBox_cen_ph_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_cen_ph.Image = new Bitmap(ofd.FileName);
                pictureBox_cen_ph.Tag = ofd.FileName;
                String pictureBox_cen_ph_path = ofd.FileName;
            }
        }

        private void pictureBox_abo_ph_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_abo_ph.Image = new Bitmap(ofd.FileName);
                pictureBox_abo_ph.Tag = ofd.FileName;
                String pictureBox_abo_ph_path = ofd.FileName;
            }
        }

        private void pictureBox_pat_ph_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_pat_ph.Image = new Bitmap(ofd.FileName);
                pictureBox_pat_ph.Tag = ofd.FileName;
                String pictureBox_pat_ph_path = ofd.FileName;
            }
        }

        private void pictureBox_best_ph_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_best_ph.Image = new Bitmap(ofd.FileName);
                pictureBox_best_ph.Tag = ofd.FileName;
                String pictureBox_best_ph_path = ofd.FileName;
            }
        }

        private void btn_search_fi_fig_Click(object sender, EventArgs e)
        {
            findFigure findfigure = new findFigure();
            findfigure.toform1 += new toForm1(listView_select_fi_fig);
            findfigure.Show();

        }

        private void listView_select_fi_fig(string fignum)
        {
            DataSet ds = DBFactory.ExcuteQuery(
                                @"SELECT * FROM TB_FIGURE WHERE FIG_NUM = "
                                + "'" + fignum + "'"
                            );

            //FIG_NUM,IMAGE,CATEGORY,DIVISION,SECTION,SYMBOL
            string fiText = ds.Tables[0].Rows[0][5].ToString(); //Image
            fiText = utfEncoding.FromUtf8(fiText);
            //피규어 이름을 표시한다
            textBox_fi_fig.Text = fiText;
            fiFigNum = utfEncoding.FromUtf8(ds.Tables[0].Rows[0][0].ToString());
            //구조체사용. fig num [0][0]저장하기
        }

        private void btn_search_la_fig_Click(object sender, EventArgs e)
        {
            findFigure findfigure = new findFigure();
            findfigure.toform1 += new toForm1(listView_select_la_fig);
            findfigure.Show();
        }

        private void listView_select_la_fig(string fignum)
        {
            DataSet ds = DBFactory.ExcuteQuery(
                                @"SELECT * FROM TB_FIGURE WHERE FIG_NUM = "
                                + "'" + fignum + "'"
                            );

            //FIG_NUM,IMAGE,CATEGORY,DIVISION,SECTION,SYMBOL
            string fiText = ds.Tables[0].Rows[0][5].ToString(); //Image
            fiText = utfEncoding.FromUtf8(fiText);
            //피규어 이름을 표시한다
            textBox_la_fig.Text = fiText;
            laFigNum = utfEncoding.FromUtf8(ds.Tables[0].Rows[0][0].ToString());
        }

    }
}
