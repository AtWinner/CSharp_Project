using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GetFileLength
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Get_Click(object sender, EventArgs e)
        {
            OpenFileDialog P_OpenFileDialog = new OpenFileDialog();//创建保存文件对话框文件
            if (P_OpenFileDialog.ShowDialog() == DialogResult.OK)//判断是否选中文件
            {
               
                MessageBox.Show("文件扩展名：" + P_OpenFileDialog.FileName.Substring(P_OpenFileDialog.FileName.LastIndexOf(".") + 1, P_OpenFileDialog.FileName.Length - P_OpenFileDialog.FileName.LastIndexOf(".") - 1) +
                    '\n'+"文件长度："+File.Open(P_OpenFileDialog.FileName, FileMode.Open).Length.ToString(), "文件信息");//弹出消息对话框
            }
            
        }

   
    }
}
