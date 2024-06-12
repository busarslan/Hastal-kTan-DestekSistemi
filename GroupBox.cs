using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hastalik_Tani_Destek_Sistemi

{
    public static class GroupBox
    {
        public static void AddGroupBox(Form form)
        {
            // Formdaki 'Menü' ve '?' butonlarının referanslarını alalım
            Button menuButton = form.Controls.OfType<Button>().FirstOrDefault(b => b.Text == "Menü");
            Button aboutButton = form.Controls.OfType<Button>().FirstOrDefault(b => b.Text == "?");

            if (menuButton == null || aboutButton == null)
            {
                throw new InvalidOperationException("Menü ve '?' butonları bulunamadı.");
            }

            System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();

            // GroupBox ayarları
            groupBox.Text = string.Empty;
            groupBox.BackColor = Color.DodgerBlue;

            // Label ayarları
            Label label = new Label();
            label.Text = "Hastalık Tanı Destek Sistemi";
            label.ForeColor = Color.Snow;
            label.Font = new Font(label.Font.FontFamily, 12, FontStyle.Bold);
            label.TextAlign = ContentAlignment.MiddleCenter;

            // Label'ı GroupBox'ın ortasına yerleştirme
            label.Dock = DockStyle.Fill;

            groupBox.Controls.Add(label);
            form.Controls.Add(groupBox);

            // Formun boyutları değiştiğinde GroupBox'ı güncelleme
            form.Resize += (sender, e) =>
            {
                UpdateGroupBoxSizeAndLocation(groupBox, menuButton, aboutButton);
            };

            // İlk boyutlandırma ve konumlandırma
            UpdateGroupBoxSizeAndLocation(groupBox, menuButton, aboutButton);
        }

        public static void AddGroupBox(Panel panel)
        {
            // Formdaki 'Menü' ve '?' butonlarının referanslarını alalım
            Button menuButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Text == "Menü");
            Button aboutButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Text == "?");

            if (menuButton == null || aboutButton == null)
            {
                throw new InvalidOperationException("Menü ve '?' butonları bulunamadı.");
            }

            System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();

            // GroupBox ayarları
            groupBox.Text = string.Empty;
            groupBox.BackColor = Color.DodgerBlue;

            // Label ayarları
            Label label = new Label();
            label.Text = "Hastalık Tanı Destek Sistemi";
            label.ForeColor = Color.Snow;
            label.Font = new Font(label.Font.FontFamily, 12, FontStyle.Bold);
            label.TextAlign = ContentAlignment.MiddleCenter;

            // Label'ı GroupBox'ın ortasına yerleştirme
            label.Dock = DockStyle.Fill;

            groupBox.Controls.Add(label);
            panel.Controls.Add(groupBox);

            // Formun boyutları değiştiğinde GroupBox'ı güncelleme
            panel.Resize += (sender, e) =>
            {
                UpdateGroupBoxSizeAndLocation(groupBox, menuButton, aboutButton);
            };

            // İlk boyutlandırma ve konumlandırma
            UpdateGroupBoxSizeAndLocation(groupBox, menuButton, aboutButton);
        }

        private static void UpdateGroupBoxSizeAndLocation(System.Windows.Forms.GroupBox groupBox, Button menuButton, Button aboutButton)
        {
            groupBox.Location = new Point(menuButton.Right + 10, 10);
            groupBox.Size = new Size(aboutButton.Left - menuButton.Right - 30, 65);
        }
    }
}