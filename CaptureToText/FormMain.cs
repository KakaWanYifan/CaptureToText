using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CaptureToText
{

    public partial class FormMain : Form
    {


        public String IniPath = AppDomain.CurrentDomain.BaseDirectory + "key.ini";
        public String CapturePath = AppDomain.CurrentDomain.BaseDirectory + "capture\\";

        public INI ini = new INI();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //初始化配置
            tb_apikey.Text = ini.ReadIniData("apikey", "value", "", IniPath);
            tb_secretkey.Text = ini.ReadIniData("secretkey", "value", "", IniPath);
        }

        private void tb_apikey_TextChanged(object sender, EventArgs e)
        {
            if (!(ini.WriteIniData("apikey", "value", tb_apikey.Text, IniPath)))
            {
                MessageBox.Show("写入apikey失败");
            }
        }

        private void tb_secretkey_TextChanged(object sender, EventArgs e)
        {
            if (!(ini.WriteIniData("secretkey", "value", tb_secretkey.Text, IniPath)))
            {
                MessageBox.Show("写入secretkey失败");
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            ni_Main.ShowBalloonTip(30, "已隐藏在右下角", "右键单击可以打开菜单栏", ToolTipIcon.Info);
            e.Cancel = true;
        }

        private void tsmi_ShowMain_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void tsmi_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void tsmi_Capture_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(300);
            FormScreen screenForm = new FormScreen();
            screenForm.ShowDialog();

        }

        private void tsmi_History_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(CapturePath);
        }

        private void ni_Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}
