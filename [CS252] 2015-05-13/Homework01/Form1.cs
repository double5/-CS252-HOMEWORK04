/******************************************************************
 * 自己建立GraphRetangle
 * Form1主程式 new GraphRetangle 物件 retangle，並參照其屬性 Length, Width, Retangle，
 * 在Form1 的 PictureBox 物件 RetanglePictureBox 顯示矩形
 
*******************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Homework01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            GraphRetangle retangle = new GraphRetangle();
            retangle.Length = int.Parse(lengthTextBox.Text);
            retangle.Width = int.Parse(widthTextBox.Text);
            retangle.Retangle = RetanglePictureBox.CreateGraphics();
            

        }
    }
}
