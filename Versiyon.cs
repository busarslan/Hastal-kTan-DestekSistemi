using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hastalik_Tani_Destek_Sistemi
{
    public static class Versiyon
    {
        public static void AddVersiyonLabel(Form form)
        {
            const string versionText = "Versiyon 19.05.24";
            Label versionLabel = null;

            foreach (Control control in form.Controls)
            {
                if (control is Label && control.Text == versionText)
                {
                    versionLabel = (Label)control;
                    break;
                }
            }

            if (versionLabel == null)
            {
                versionLabel = new Label
                {
                    Text = versionText,
                    AutoSize = true
                };
                form.Controls.Add(versionLabel);
            }

            versionLabel.Location = new Point((form.ClientSize.Width - versionLabel.Width) / 2, form.ClientSize.Height - versionLabel.Height);

            versionLabel.BringToFront();
        }
    }
}