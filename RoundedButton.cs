using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hastalik_Tani_Destek_Sistemi

{
    public class RoundedButton : Button
    {
        public int BorderSize { get; set; }
        private Color originalBackColor;

        public Image ButtonImage { get; set; }

        public RoundedButton()
        {
            BorderSize = 10;
            this.BackColor = Color.Snow; // Default background color
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            this.BackColor = ControlPaint.Dark(this.BackColor);
            this.Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            this.BackColor = Color.FromArgb(255, 55, 55); // Reset to default background color
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            int cornerRadius = 45;

            graphicsPath.AddArc(new Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90);
            graphicsPath.AddArc(new Rectangle(Width - cornerRadius, 0, cornerRadius, cornerRadius), 270, 90);
            graphicsPath.AddArc(new Rectangle(Width - cornerRadius, Height - cornerRadius, cornerRadius, cornerRadius), 0, 90);
            graphicsPath.AddArc(new Rectangle(0, Height - cornerRadius, cornerRadius, cornerRadius), 90, 90);
            graphicsPath.CloseFigure();

            this.Region = new Region(graphicsPath);

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (Brush brush = new SolidBrush(this.BackColor))
            {
                pevent.Graphics.FillPath(brush, graphicsPath);
            }

            if (ButtonImage != null)
            {
                Rectangle imageRect = new Rectangle((this.Width - ButtonImage.Width) / 2, (this.Height - ButtonImage.Height) / 2, ButtonImage.Width, ButtonImage.Height);
                pevent.Graphics.DrawImage(ButtonImage, imageRect);
            }

            using (Pen pen = new Pen(this.ForeColor, BorderSize))
            {
                pevent.Graphics.DrawPath(pen, graphicsPath);
            }

            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            if (this.Focused)
            {
                ControlPaint.DrawFocusRectangle(pevent.Graphics, this.ClientRectangle);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.Invalidate();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.Invalidate();
        }
    }
}