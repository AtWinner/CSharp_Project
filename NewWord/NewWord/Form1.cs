using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;//ThreadPool.QueueUserWorkItem
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;//Microsoft.Office.Interop.Word.Application();的命名空间

namespace NewWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            btn_New.Enabled = false;//将新建按钮设置为不可用
            ThreadPool.QueueUserWorkItem(//开始线程池
                (pp) =>
                {
                    object G_missing = System.Reflection.Missing.Value;
                    object G_str_path = System.Reflection.Missing.Value;
                    Word.Application G_wa = new Microsoft.Office.Interop.Word.Application();//创建应用程序对象
                    object P_obj = "Normal.dot";//定义文档模版
                   
                    
                    FolderBrowserDialog G_FolderBrowserDialog = new FolderBrowserDialog();
                    Word.Document P_wd = G_wa.Documents.Add(ref P_obj, ref G_missing, ref G_missing, ref G_missing);
                    G_str_path = string.Format(//计算文件保存路径
                        @"{0}\{1}",G_FolderBrowserDialog.SelectedPath,DateTime.Now.ToString("yyyy年M月d日h时s秒fff毫秒")+".doc"
                        );
                    P_wd.SaveAs(
                        ref G_str_path,
                        ref G_missing,ref G_missing,ref G_missing,ref G_missing,
                        ref G_missing,ref G_missing,ref G_missing,ref G_missing,
                        ref G_missing,ref G_missing,ref G_missing,ref G_missing,
                        ref G_missing,ref G_missing,ref G_missing
                        );
                    
                    
                    ((Word.Application)G_wa.Application).Quit(ref G_missing, ref G_missing, ref G_missing);
                    this.Invoke(
                        (MethodInvoker)(()=>
                            {
                                MessageBox.Show("Word文档已经建立！","提示！");
                                btn_diplay.Enabled = true;
                            }
                            )
                        );
                }); 
        }

      
    }
}
