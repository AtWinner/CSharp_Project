using System;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CRRemoteComputer
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseComputer("ShutDown");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void CloseComputer(string doinfo)
        {
            ConnectionOptions op = new ConnectionOptions();//
            op.Username = textBox3.Text;
            
        }
    }
}
