using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hastalik_Tani_Destek_Sistemi
{
    public class ObjectFontAdjustment
    {
        public void AdjustButtonFontSize(Button button1, float clientSizeWidthProp)
        {
            float newFontSize = clientSizeWidthProp / 50f;
            newFontSize = Math.Max(newFontSize, 8);
            newFontSize = Math.Min(newFontSize, 30);

            button1.Font = new Font(button1.Font.FontFamily, newFontSize);
        }

        public void AdjustLabelFontSize_SP(RoundedLabel label, float clientSizeWidthProp)
        {
            float labelFontSize = clientSizeWidthProp / 70f;
            labelFontSize = Math.Max(labelFontSize, 10);
            labelFontSize = Math.Min(labelFontSize, 40);

            label.Font = new Font(label.Font.FontFamily, labelFontSize);
        }

        public void AdjustDownLabelFontSize_SP(RoundedLabel label, float clientSizeWidthProp)
        {
            float labelFontSize = clientSizeWidthProp / 55f;
            labelFontSize = Math.Max(labelFontSize, 15);
            labelFontSize = Math.Min(labelFontSize, 30);

            label.Font = new Font(label.Font.FontFamily, labelFontSize);
        }
    }
}
