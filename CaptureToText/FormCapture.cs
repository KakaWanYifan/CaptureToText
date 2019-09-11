using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Baidu.Aip.Ocr;
using Newtonsoft.Json.Linq;

namespace CaptureToText
{
    public partial class FormCapture : Form
    {
        private Bitmap CaptureImg;

        public String IniPath = AppDomain.CurrentDomain.BaseDirectory + "key.ini";
        public String CapturePath = AppDomain.CurrentDomain.BaseDirectory + "capture\\";

        public INI ini = new INI();

        public FormCapture()
        {
            InitializeComponent();
        }

        private void FormCapture_Load(object sender, EventArgs e)
        {

        }

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        public void Snap(int x, int y, int width, int height)
        {
            //把图片赋值给 pb_Capture
            pb_Capture.BackgroundImageLayout = ImageLayout.Zoom;
            CaptureImg = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(CaptureImg);
            g.CopyFromScreen(x, y, 0, 0, new System.Drawing.Size(width, height));
            if (width < pb_Capture.Width && height < pb_Capture.Height)
            {
                pb_Capture.BackgroundImageLayout = ImageLayout.Center;
            }
            pb_Capture.BackgroundImage = CaptureImg;

            // 保存文件到本地
            System.Drawing.Imaging.Encoder eQuality = System.Drawing.Imaging.Encoder.Quality;
            EncoderParameter epQuality = new EncoderParameter(eQuality, 100L);
            EncoderParameters epQuality_s = new EncoderParameters();
            epQuality_s.Param[0] = epQuality;
            if(!Directory.Exists(CapturePath))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(CapturePath);
                directoryInfo.Create();
            }
            String filename = System.Guid.NewGuid().ToString();
            CaptureImg.Save(CapturePath + filename + ".jpg", GetEncoderInfo("image/jpeg"), epQuality_s);

            // 识别图片
            String API_KEY = ini.ReadIniData("apikey", "value", "", IniPath);
            String SECRET_KEY = ini.ReadIniData("secretkey", "value", "", IniPath);
            Ocr client = new Ocr(API_KEY, SECRET_KEY);
            client.Timeout = 60000;  // 修改超时时间
            byte[] image = File.ReadAllBytes(CapturePath + filename + ".jpg");
            JObject textJsonObject = client.GeneralBasic(image);

            // 组装text
            String text = "";
            if (textJsonObject["words_result"] != null)
            {
                JArray ja = JArray.Parse(textJsonObject["words_result"].ToString());
                foreach(JObject jo in ja)
                {
                    text = text + jo["words"].ToString() + "\n";
                }
            }
            else
            {
                text = "【识别错误】" + "\n"
                    + "错误信息为" + "\n"
                    + textJsonObject.ToString();
            }
            rtb_Text.Text = text;
            //复制给粘贴板
            Clipboard.SetDataObject(text);
        }
    }
}
