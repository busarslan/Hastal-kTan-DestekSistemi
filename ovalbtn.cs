using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class OvalButton : Button
{
    protected override void OnPaint(PaintEventArgs e)
    {
        GraphicsPath path = new GraphicsPath();
        path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
        this.Region = new Region(path);
        base.OnPaint(e);
    }
}