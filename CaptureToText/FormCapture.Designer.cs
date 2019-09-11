namespace CaptureToText
{
    partial class FormCapture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_Capture = new System.Windows.Forms.PictureBox();
            this.rtb_Text = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Capture)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Capture
            // 
            this.pb_Capture.Location = new System.Drawing.Point(12, 13);
            this.pb_Capture.Name = "pb_Capture";
            this.pb_Capture.Size = new System.Drawing.Size(368, 150);
            this.pb_Capture.TabIndex = 0;
            this.pb_Capture.TabStop = false;
            // 
            // rtb_Text
            // 
            this.rtb_Text.Location = new System.Drawing.Point(13, 170);
            this.rtb_Text.Name = "rtb_Text";
            this.rtb_Text.ReadOnly = true;
            this.rtb_Text.Size = new System.Drawing.Size(367, 176);
            this.rtb_Text.TabIndex = 1;
            this.rtb_Text.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "已复制到粘贴板";
            // 
            // FormCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_Text);
            this.Controls.Add(this.pb_Capture);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCapture";
            this.Text = "FormCapture";
            this.Load += new System.EventHandler(this.FormCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Capture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Capture;
        private System.Windows.Forms.RichTextBox rtb_Text;
        private System.Windows.Forms.Label label1;
    }
}