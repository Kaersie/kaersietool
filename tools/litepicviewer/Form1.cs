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
  
    
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
               try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK) { pictureBox1.Load(openFileDialog1.FileName); }
                textbox1.Text = openFileDialog1.FileName;
                filename.f = openFileDialog1.FileName;
               }
            catch (System.ArgumentException)
            {
                MessageBox.Show("此文件不支持");

            }//打开文件，如果错误就显示
           
            }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image=null;
            textbox1.Text = "";
        }

        

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            f11 f11 = new f11();
            f11.Show();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
 if (e.Data.GetDataPresent(DataFormats.FileDrop)){
                e.Effect = DragDropEffects.All;
                try
                {

                    pictureBox1.Load(((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString());
                    textbox1.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                    filename.f = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show("此文件不支持");

                }//重要代码：表明是所有类型的数据，比如文件路径
 }
 else { 
                e.Effect = DragDropEffects.None;
 }

        }
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            
            //重要代码：表明是所有类型的数据，比如文件路径

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var str in Environment.GetCommandLineArgs())
            {
                MessageBox.Show(str);
            }
        }

        }
    public class filename
    {
        public static string f;
    }
   

}
    

