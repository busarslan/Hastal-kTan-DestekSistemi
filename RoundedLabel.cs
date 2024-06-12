using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hastalik_Tani_Destek_Sistemi
{
    public class RoundedLabel : Label
    {
        public Image LabelImage { get; set; }
        public Color BorderColor { get; set; }
        public int BorderWidth { get; set; }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            int cornerRadius = 20;

            graphicsPath.AddArc(new Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90);
            graphicsPath.AddArc(new Rectangle(Width - cornerRadius, 0, cornerRadius, cornerRadius), 270, 90);
            graphicsPath.AddArc(new Rectangle(Width - cornerRadius, Height - cornerRadius, cornerRadius, cornerRadius), 0, 90);
            graphicsPath.AddArc(new Rectangle(0, Height - cornerRadius, cornerRadius, cornerRadius), 90, 90);
            graphicsPath.CloseFigure();

            this.Region = new Region(graphicsPath);

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (BorderColor != Color.Transparent && BorderWidth > 0)
            {
                using (Pen borderPen = new Pen(BorderColor, BorderWidth))
                {
                    pevent.Graphics.DrawPath(borderPen, graphicsPath);
                }
            }

            if (LabelImage != null)
            {
                Rectangle imageRect = new Rectangle(
                    (this.Width - LabelImage.Width) / 2,
                    (this.Height - LabelImage.Height) / 2,
                    LabelImage.Width,
                    LabelImage.Height);
                pevent.Graphics.DrawImage(LabelImage, imageRect);
            }

            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
