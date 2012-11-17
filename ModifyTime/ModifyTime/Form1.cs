using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ModifyTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog P_OpenFileDialog = new OpenFileDialog();
            if (P_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(P_OpenFileDialog.FileName);//创建fileinfo对象
                MessageBox.Show("最后一次修改时间："+fileInfo.LastWriteTime.ToString(),"提示！");
            }
        }
    }
}
