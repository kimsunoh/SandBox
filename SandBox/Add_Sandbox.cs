using OpenCvSharp;
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
            insertForDB(); //모래상자정보 insert
            harrDetect();  //물체검출 알고리즘 Haar
        }

        private void harrDetect()
        {
            //각각의 사진들에 대해
                //입력된 사진에 대해 피규어인식
                //인식된 피규어 이미지 받고 DB에서 있는지 확인
                //if 유무판단후 DB에 저장

            List<string> sandbox;
            // TEST용 시나리오
            // 사진들에서 피규어 찾아내고 메세지 띄우기
            if (FaceDetect(@"C:\!TestSet\sampleimage\1.jpg", @"C:\!TestSet\CascadeTrainer\cascade.xml"))
            {
                MessageBox.Show("fig1");
            }
            else
            {
                MessageBox.Show("not founded");
            }
        }

        private void insertForDB()
        {
            //TB_SANDBOX

        }
        private bool FaceDetect(string sandboxPath, string cascadeXmlPath)
        {
            //using (IplImage img = new IplImage(sandboxPath, LoadMode.Color))
            using (IplImage img = Cv.LoadImage(sandboxPath, LoadMode.Color))
            {
                using (IplImage gray = new IplImage(img.Size, BitDepth.U8, 1))
                {
                    Cv.CvtColor(img, gray, ColorConversion.BgrToGray);
                    Cv.Resize(gray, img, Interpolation.Linear);
                    Cv.EqualizeHist(img, img);
                    //EqualizeHist = 히스토그램 평활화. 그레이 이미지를 특출나게 어둡거나 밝은 부분을 적당히 펴줘서 전체 값이 일정하게 되도록 해줌
                }

                using (CvHaarClassifierCascade cascade = CvHaarClassifierCascade.FromFile(cascadeXmlPath))
                //haarcascade_frontalface_alt2.xml얼굴 검출에 대한 기계학습 자료가 담겨져 있음.
                //이자료와 비교해서 비슷하면 얼굴로 인식하게 되어 있음
                using (CvMemStorage storage = new CvMemStorage())
                {
                    storage.Clear();
                    //얼굴의 검출
                    CvSeq faces = Cv.HaarDetectObjects(img, cascade, storage, 1.1, 2, 0, new CvSize(30, 30));
                    //검출된 얼굴을 facesdp 저장. faces.Total에 총 검풀된 얼굴수가 들어가 있음
                    return (faces.Total > 0);
                }
            }
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
            fiFigNum = ds.Tables[0].Rows[0][0].ToString();
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
            laFigNum = ds.Tables[0].Rows[0][0].ToString();
        }

    }
}
