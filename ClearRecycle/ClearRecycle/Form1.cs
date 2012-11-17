using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ClearRecycle
{
    public partial class Form1 : Form
    {
        const int SHERB_NOCONFIRMATION = 0x000001;//整型常量在API中表示删除时没有确认对话框
        const int SHERB_NOPROGRESSUI = 0x000002;//在API中表示不显示删除进度条
        const int SHERB_NOSOUND = 0x000004;//在API中表示删除完毕时不播放声音
        [DllImportAttribute("shell32.dll")]// 声明API函数
        private static extern int SHEmptyRecyleBin(IntPtr handle, string root, int falgs);
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SHEmptyRecyleBin(this.Handle, "", SHERB_NOCONFIRMATION + SHERB_NOPROGRESSUI + SHERB_NOSOUND);
        }
    }
}
