using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class CustomGroupBox : GroupBox
{
    private Color borderColor = Color.Black;
    private int borderWidth = 0;

    [Category("Appearance")]
    [Description("The color of the border.")]
    public Color BorderColor
    {
        get { return borderColor; }
        set
        {
            borderColor = value;
            Invalidate(); // Redraw the control
        }
    }

    [Category("Appearance")]
    [Description("The width of the border.")]
    public int BorderWidth
    {
        get { return borderWidth; }
        set
        {
            borderWidth = value;
            Invalidate();
        }
    }

    public CustomGroupBox()
    {
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        BackColor = Color.Transparent;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (var pen = new Pen(BorderColor, BorderWidth))
        {
            e.Graphics.DrawRectangle(pen, ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
        }
    }
}