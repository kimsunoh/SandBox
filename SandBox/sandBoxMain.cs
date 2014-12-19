using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//#include <atlstr.h>
using System;
using System.Text;


namespace SandBox
{
    public partial class sandBoxMain : Form
    {
        private String selectedSex;
        private String fignum;
        private String patnum;
        
        public sandBoxMain()
        {
            InitializeComponent();
            search_Patient.toform2 += new toForm2(listView_select_pat);
        }

        private void listView_select_pat(string patnum)
        {
            this.patnum = patnum;
            view_pat_infor();
        }

        private void view_pat_infor()
        {
            //throw new System.NotImplementedException();
            DataSet ds = DBFactory.ExcuteQuery(
                                @"SELECT * FROM TB_PATIENT WHERE PAT_NUM = "
                                + "'" + patnum + "'"
                            );

            //IDX,PAT_NUM,PAT_NAME,PAT_AGE,PAT_SEX,PAT_FEATURE
            string patName = ds.Tables[0].Rows[0][2].ToString(); //Image
            patName = utfEncoding.FromUtf8(patName);
            //text를 표시한다
            view_pat_name.Visible = true;
            view_pat_name.Text = patName;
        }
        void listView_select_fig(string fignum)
        {
            this.fignum = fignum;
            view_fig_imfor();
        }
        private void sandBoxMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show(" Welcome! - id : " + Session.curSession.id);
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_add_fig_Click(object sender, EventArgs e)
        {

        }

        private void btn_find_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_fig_img.Image = new Bitmap(ofd.FileName);
                pictureBox_fig_img.Tag = ofd.FileName;
                String pictureBox_fig_img_path = ofd.FileName;
                //경로보여주기_ 감춰도 될듯
                tb_img_path.Text = pictureBox_fig_img_path;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_figure_add_Click(object sender, EventArgs e)
        {
            if (pictureBox_fig_img.Tag.ToString() == null)
            {
                Console.WriteLine("No Image");
                MessageBox.Show("이미지를 선택해 주십시오");
                return;
            }

            int fNum = Add_FigureToDb();
            //추가된 fig이미지를 positive sample 이미지 리스트 테이블에 추가 
            string strCmdText;
            string pathFigureImagePath = tb_img_path.Text;
            strCmdText = @"cd C:\_SandBox\cascadeExcercise\";
            // strCmdText = strCmdText + " & " + "";
            strCmdText = strCmdText + " & " + @"mkdir C:\_SandBox\cascadeExcercise\" + fNum;
            //strCmdText = strCmdText + " & " + @"cd C:\_SandBox\cascadeExcercise\" + fNum;
            strCmdText = strCmdText + " & " + @"C:\_SandBox\openCv\bin\opencv_traincascade.exe";
            System.Diagnostics.Process.Start("CMD.exe", "/C " + strCmdText); //cmd에서 기계학습시키기
            MessageBox.Show("Done.");
        }
        //
        /*register Error*/
        //
        private int Add_FigureToDb(){
            FileStream fs = new FileStream(pictureBox_fig_img.Tag.ToString(), FileMode.Open, FileAccess.Read);
            byte[] bImage = new byte[fs.Length];
            fs.Read(bImage, 0, (int)fs.Length);

            int fNum = int.Parse(DBFactory.ExcuteQuery(@"SELECT count(*) FROM TB_FIGURE").Tables[0].Rows[0][0].ToString());
            fNum++;

            DBFactory.ExcuteNonQuery(
                @"INSERT INTO "
                + @" TB_FIGURE (FIG_NUM,IMAGE,CATEGORY,DIVISION,SECTION,SYMBOL)"
                + @"VALUES"
                + @"('" + fNum
                + "','"
                + utfEncoding.ToUtf8(tb_img_path.Text) + "','"
                + utfEncoding.ToUtf8(comboBox_add_cate.Text) + "','"
                + utfEncoding.ToUtf8(comboBox_add_div.Text) + "','"
                + utfEncoding.ToUtf8(comboBox_add_sel.Text) + "','"
                + utfEncoding.ToUtf8(textBox_add_sym.Text) + "')"
            );
            fs.Close();
            return fNum;
        }

        private void btn_find_fig_Click(object sender, EventArgs e)
        {
            find_fig();
        }

        private void view_fig_imfor()
        {
            //throw new System.NotImplementedException();
            DataSet ds = DBFactory.ExcuteQuery(
                                @"SELECT * FROM TB_FIGURE WHERE FIG_NUM = "
                                + "'" + fignum + "'"
                            );

            //FIG_NUM,IMAGE,CATEGORY,DIVISION,SECTION,SYMBOL
            string imgAdd = ds.Tables[0].Rows[0][1].ToString(); //Image
            imgAdd = utfEncoding.FromUtf8(imgAdd);
            //이미지의 크기를 PictureBox에 맞춘다
            pictureBox_view_fig.SizeMode = PictureBoxSizeMode.StretchImage;
            //이미지를 표시한다
            pictureBox_view_fig.Image = System.Drawing.Image.FromFile(imgAdd);
        }

        private findFigure find_fig()
        {
            findFigure ff = new findFigure();
            ff.toform1 += new toForm1(listView_select_fig);
            ff.Show();

            return ff;
        }

        private void btn_amend_fig_Click(object sender, EventArgs e)
        {

        }

        private void btn_del_fig_Click(object sender, EventArgs e)
        {

        }

        private void rd_sex_fem_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedSex = "여";
        }

        private void rd_sex_man_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedSex = "남";
        }

        private void btn_pat_add_Click(object sender, EventArgs e)
        {
            if (Add_patient())
            {
                MessageBox.Show("Done.");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private bool Add_patient()
        {
           // throw new System.NotImplementedException();
            if (textBox_name.ToString() == null)
            {
                Console.WriteLine("No name");
                return false;
            }
            else
            {
                DBFactory.ExcuteNonQuery(
                    @"INSERT INTO "
                    + @" TB_PATIENT (IDX,PAT_NUM,PAT_NAME,PAT_AGE,PAT_SEX,PAT_FEATURE)"
                    + @"VALUES"
                    + @"('" + Session.curSession.id + "','"
                    + (new Random()).Next(1000000000) + "','"
                    + utfEncoding.ToUtf8(textBox_name.Text) + "','"
                    + int.Parse(textBox_age.Text) + "','"
                    + utfEncoding.ToUtf8(this.selectedSex) + "','"
                    + utfEncoding.ToUtf8(textbox_feat.Text) + "')"
                );
                return true;
            }
        }

        private void btn_pat_search_Click(object sender, EventArgs e)
        {
            find_pat();
        }

        private search_Patient find_pat()
        {
            search_Patient sp = new search_Patient();
            sp.Show();
            return sp;
        }

        private void btn_view_coun_Click(object sender, EventArgs e)
        {
            (new counsel()).Show();
        }

        private void btn_sb_add_Click(object sender, EventArgs e)
        {
            (new Add_Sandbox()).Show();
        }

        private void textbox_view_feat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_search_pat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tb_search_fig_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
    class utfEncoding
    {
        internal static string ToUtf8(string utf8String)
        {
            if (utf8String == null)
            {
                return null;
            }
            byte[] buffer = Encoding.Unicode.GetBytes(utf8String);
            return Convert.ToBase64String(buffer);
        }

        internal static string FromUtf8(string utf8String)
        {
            if (utf8String == null)
            {
                return null;
            }
            byte[] buffer = Convert.FromBase64String(utf8String);
            return Encoding.Unicode.GetString(buffer);
        }
    }
}