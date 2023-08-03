using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace litepicviewer
{
   
   
    public partial class f11 : Form
    {
       
        Form1 mainf = new Form1();
        public f11()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
         
        }

        private void f11_Load(object sender, EventArgs e)
        {
                try
            {
                pictureBox1.Load(filename.f);            }
                catch (System.InvalidOperationException)
            {
                MessageBox.Show("此文件不支持","极简图片查看");

            }//打开文件，如果错误就显示
           
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 右键ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
