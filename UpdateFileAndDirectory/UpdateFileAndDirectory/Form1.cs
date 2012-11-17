/*
目的：修改文件及目录的名字
方法：
 * file类的move方法：public static void main(string sourceFilename,string destFileName)
 * Directory类的move方法:public static void main(string sourceDirName,string deskDirName)
 * sourceFilename:要移动的文件或目录的路径
 * destDirName:指向sourceDirName的新位置的路径。如果sourceDirName是一个文件，则destDirName也必须是一个文件名
 * destFileName文件的新路径
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UpdateFileAndDirectory
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
    }
}
