using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hastalik_Tani_Destek_Sistemi
{
    public class CircleButtonStartPage : Button
    {
        private Image circlebuttonImage;
        public Image ButtonImage
        {
            get { return circlebuttonImage; }
            set
            {
                circlebuttonImage = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            int diameter = Math.Min(this.Width, this.Height);
            int x = (this.Width - diameter) / 2;
            int y = (this.Height - diameter) / 2;

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(x, y, diameter, diameter);
            this.Region = new Region(graphicsPath);

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (Brush brush = new SolidBrush(this.BackColor))
            {
                pevent.Graphics.FillPath(brush, graphicsPath);
            }

            if (circlebuttonImage != null)
            {
                Rectangle imageRect = new Rectangle(x, y, diameter, diameter);
                pevent.Graphics.DrawImage(circlebuttonImage, imageRect);
            }
            else
            {
                TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font,
                    new Rectangle(0, 0, this.Width, this.Height), this.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }
    }
}
