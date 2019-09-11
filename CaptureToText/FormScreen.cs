using System;
using System.Drawing;
using System.Windows.Forms;

namespace CaptureToText
{
    public partial class FormScreen : Form
    {
        int x, y, nowX, nowY, width, height;
        bool isMouthDown = false;
        Graphics g;

        public FormScreen()
        {
            InitializeComponent();
        }

        private void ScreenForm_MouseDown(object sender, MouseEventArgs e)
        {
            x = MousePosition.X;
            y = MousePosition.Y;
            isMouthDown = true;
        }

        private void ScreenForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouthDown)
            {
                width = Math.Abs(MousePosition.X - x);
                height = Math.Abs(MousePosition.Y - y);
                g = CreateGraphics();
                g.Clear(BackColor);
                g.FillRectangle(Brushes.CornflowerBlue, x<MousePosition.X?x:MousePosition.X, y<MousePosition.Y?y:MousePosition.Y, width + 1, height + 1);
            }
        }

        private void ScreenForm_MouseUp(object sender, MouseEventArgs e)
        {
            nowX = MousePosition.X + 1;
            nowY = MousePosition.Y + 1;
            this.Close();
            FormCapture fc = new FormCapture();
            fc.Snap(x < nowX ? x : nowX, y < nowY ? y : nowY, Math.Abs(nowX - x), Math.Abs(nowY - y));
            fc.Show();
        }

    }
}
