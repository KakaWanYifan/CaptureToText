namespace CaptureToText
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tb_Desc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_apikey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_secretkey = new System.Windows.Forms.TextBox();
            this.ni_Main = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ShowMain = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Capture = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_History = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.cms_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Desc
            // 
            this.tb_Desc.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Desc.Location = new System.Drawing.Point(12, 33);
            this.tb_Desc.Multiline = true;
            this.tb_Desc.Name = "tb_Desc";
            this.tb_Desc.ReadOnly = true;
            this.tb_Desc.Size = new System.Drawing.Size(368, 109);
            this.tb_Desc.TabIndex = 0;
            this.tb_Desc.Text = "1、截图等操作请右键单击桌面右下角的图标\r\n2、首次使用请填写API Key和Secret Key\r\n3、请通过以下网址申请API Key和Secret Key\r" +
    "\n   https://ai.baidu.com/tech/ocr/general";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "API Key";
            // 
            // tb_apikey
            // 
            this.tb_apikey.Location = new System.Drawing.Point(12, 172);
            this.tb_apikey.Multiline = true;
            this.tb_apikey.Name = "tb_apikey";
            this.tb_apikey.Size = new System.Drawing.Size(368, 47);
            this.tb_apikey.TabIndex = 2;
            this.tb_apikey.TextChanged += new System.EventHandler(this.tb_apikey_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Secret Key";
            // 
            // tb_secretkey
            // 
            this.tb_secretkey.Location = new System.Drawing.Point(12, 246);
            this.tb_secretkey.Multiline = true;
            this.tb_secretkey.Name = "tb_secretkey";
            this.tb_secretkey.Size = new System.Drawing.Size(368, 115);
            this.tb_secretkey.TabIndex = 4;
            this.tb_secretkey.TextChanged += new System.EventHandler(this.tb_secretkey_TextChanged);
            // 
            // ni_Main
            // 
            this.ni_Main.ContextMenuStrip = this.cms_Main;
            this.ni_Main.Icon = ((System.Drawing.Icon)(resources.GetObject("ni_Main.Icon")));
            this.ni_Main.Text = "CaptureToText";
            this.ni_Main.Visible = true;
            // 
            // cms_Main
            // 
            this.cms_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Exit,
            this.tsmi_History,
            this.tsmi_ShowMain,
            this.tsmi_Capture});
            this.cms_Main.Name = "cms_Main";
            this.cms_Main.ShowImageMargin = false;
            this.cms_Main.Size = new System.Drawing.Size(128, 114);
            // 
            // tsmi_Exit
            // 
            this.tsmi_Exit.Name = "tsmi_Exit";
            this.tsmi_Exit.Size = new System.Drawing.Size(127, 22);
            this.tsmi_Exit.Text = "退出";
            this.tsmi_Exit.Click += new System.EventHandler(this.tsmi_Exit_Click);
            // 
            // tsmi_ShowMain
            // 
            this.tsmi_ShowMain.Name = "tsmi_ShowMain";
            this.tsmi_ShowMain.Size = new System.Drawing.Size(127, 22);
            this.tsmi_ShowMain.Text = "设置";
            this.tsmi_ShowMain.Click += new System.EventHandler(this.tsmi_ShowMain_Click);
            // 
            // tsmi_Capture
            // 
            this.tsmi_Capture.Name = "tsmi_Capture";
            this.tsmi_Capture.Size = new System.Drawing.Size(127, 22);
            this.tsmi_Capture.Text = "截图";
            this.tsmi_Capture.Click += new System.EventHandler(this.tsmi_Capture_Click);
            // 
            // tsmi_History
            // 
            this.tsmi_History.Name = "tsmi_History";
            this.tsmi_History.Size = new System.Drawing.Size(127, 22);
            this.tsmi_History.Text = "历史";
            this.tsmi_History.Click += new System.EventHandler(this.tsmi_History_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "帮助与说明";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 373);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_secretkey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_apikey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Desc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "CaptureToText";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.cms_Main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_apikey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_secretkey;
        private System.Windows.Forms.NotifyIcon ni_Main;
        private System.Windows.Forms.ContextMenuStrip cms_Main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Capture;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Exit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ShowMain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem tsmi_History;
    }
}

