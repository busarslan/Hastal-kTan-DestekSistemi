
using System;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Hastalik_Tani_Destek_Sistemi
{
    public class ObjectResize
    {
        public void ResizeMainLabel_SP(RoundedLabel Current_Label, float clientSizeWidthProp, float clientSizeHeightProp)
        {
            int labelWidth = Convert.ToInt32(clientSizeWidthProp / 1.9f);
            int labelHeight = Convert.ToInt32(clientSizeHeightProp / 9);

            labelWidth = Math.Max(labelWidth, 80);
            labelHeight = Math.Max(labelHeight, 40);
            labelWidth = Math.Min(labelWidth, 900);

            Current_Label.Width = labelWidth;
            Current_Label.Height = labelHeight;

            int totalWidth = Current_Label.Width;
            int startX = Convert.ToInt32((clientSizeWidthProp - totalWidth) / 2);

            Current_Label.Left = startX;
            Current_Label.Top = 2;
        }

        public void ResizeNormalLabel_SP(RoundedLabel Current_Label, float clientSizeWidthProp, float clientSizeHeightProp, double abc)
        {
            int labelWidth = Convert.ToInt32(clientSizeWidthProp / 3f);
            int labelHeight = Convert.ToInt32(clientSizeHeightProp / 9);

            labelWidth = Math.Max(labelWidth, 30);
            labelHeight = Math.Max(labelHeight, 30);
            labelWidth = Math.Min(labelWidth, 900);
            
            Current_Label.Width = labelWidth;
            Current_Label.Height = labelHeight;

            int totalWidthSL = Current_Label.Width;
            int startXSL = Convert.ToInt32((clientSizeWidthProp * abc - totalWidthSL / 2));
            Current_Label.Left = startXSL;

            Current_Label.Top = Convert.ToInt32(clientSizeHeightProp - 1 - Current_Label.Height);
        }

        public void ResizeCenterCircle_SP(CircleButtonStartPage Current_Circle, float clientSizeWidthProp, float clientSizeHeightProp)
        {
            
            int CircularHeight = Convert.ToInt32(clientSizeHeightProp / 3.5);
            int CircularWidth = CircularHeight;

            CircularWidth = Math.Max(CircularWidth, 80);
            CircularHeight = Math.Max(CircularHeight, 80);

            Current_Circle.Width = CircularWidth;
            Current_Circle.Height = CircularHeight;

            int centerX = Convert.ToInt32((clientSizeWidthProp - Current_Circle.Width) / 2);
            int centerY = Convert.ToInt32((clientSizeHeightProp - Current_Circle.Height) / 2);
            Current_Circle.Location = new Point(centerX, centerY);
        }
    }
}