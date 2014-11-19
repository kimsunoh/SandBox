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
        public Add_Sandbox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_sb_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = @"copy c:\sandBox\a.txt c:\sandBox\b.txt";
            System.Diagnostics.Process.Start("CMD.exe", "/C " + strCmdText);
        }
    }
}
