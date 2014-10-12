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
    public partial class sandBoxMain : Form
    {
        public sandBoxMain()
        {
            InitializeComponent();
        }

        private void sandBoxMain_Load(object sender, EventArgs e)
        {

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

        }

        private void btn_find_fig_Click(object sender, EventArgs e)
        {

        }

        private void btn_amend_fig_Click(object sender, EventArgs e)
        {

        }

        private void btn_del_fig_Click(object sender, EventArgs e)
        {

        }

        private void sex_fem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sex_man_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_pat_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_pat_search_Click(object sender, EventArgs e)
        {

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
    }
}
