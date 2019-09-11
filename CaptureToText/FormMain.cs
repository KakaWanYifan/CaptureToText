using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptureToText
{

    public partial class FormMain : Form
    {
        public string FullPath_Cfg = AppDomain.CurrentDomain.BaseDirectory + "key.ini";
        public INI ini = new INI();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //初始化配置
            tb_apikey.Text = ini.ReadIniData("apikey", "value", "", FullPath_Cfg);
            tb_secretkey.Text = ini.ReadIniData("secretkey", "value", "", FullPath_Cfg);
    //        // 设置APPID/AK/SK
    //        //var APP_ID = "你的 App ID";
    //        var API_KEY = "vTjrNlPbwv48gsnfGSkyFhVf";
    //        var SECRET_KEY = "Y6DiGAcFoKODoMU3dN1h2LYGmo7LR3hN";

    //        var client = new Baidu.Aip.Ocr.Ocr(API_KEY, SECRET_KEY);
    //        client.Timeout = 60000;  // 修改超时时间

    //        var url = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1568114381262&di=6fc1944b3361d45ead3f0a9db386fbe5&imgtype=0&src=http%3A%2F%2Fi4.hexunimg.cn%2F2016-10-11%2F186368488.jpg";

    //        // 调用通用文字识别, 图片参数为远程url图片，可能会抛出网络等异常，请使用try/catch捕获
    //        var result = client.GeneralBasicUrl(url);
    //        Console.WriteLine(result);
    //        // 如果有可选参数
    //        var options = new Dictionary<string, object>{
    //    {"language_type", "CHN_ENG"},
    //    {"detect_direction", "true"},
    //    {"detect_language", "true"},
    //    {"probability", "false"}
    //};
    //        // 带参数调用通用文字识别, 图片参数为远程url图片
    //        result = client.GeneralBasicUrl(url, options);
    //        Console.WriteLine(result);
        }

        private void tb_apikey_TextChanged(object sender, EventArgs e)
        {
            if (!(ini.WriteIniData("apikey", "value", tb_apikey.Text, FullPath_Cfg)))
            {
                MessageBox.Show("写入apikey失败");
            }
        }

        private void tb_secretkey_TextChanged(object sender, EventArgs e)
        {
            if (!(ini.WriteIniData("secretkey", "value", tb_secretkey.Text, FullPath_Cfg)))
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
    }
}
