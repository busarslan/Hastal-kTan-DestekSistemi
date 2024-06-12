using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hastalik_Tani_Destek_Sistemi
{
    public static class HakkindaButonu
    {
        public static void AddAboutButton(Form form)
        {
            Label labelInfo = InitializeLabelInfo(form);

            Button aboutButton = new Button();
            aboutButton.Text = "?";
            aboutButton.Font = new Font(aboutButton.Font.FontFamily, 10, FontStyle.Bold);
            aboutButton.Size = new Size(30, 30);
            aboutButton.Location = new Point(form.ClientSize.Width - aboutButton.Width - 10, 10);
            aboutButton.Anchor = AnchorStyles.Top | AnchorStyles.Right; // Sağ üst köşede sabit kalması için
            aboutButton.Click += (sender, e) => ToggleLabelVisibility(labelInfo);
            form.Controls.Add(aboutButton);
        }

        public static void AddAboutButton(Panel panel)
        {
            // Panelin AutoScroll özelliğini etkinleştiriyoruz
            panel.AutoScroll = true;

            Label labelInfo = InitializeLabelInfo(panel);

            Button aboutButton = new Button();
            aboutButton.Text = "?";
            aboutButton.Font = new Font(aboutButton.Font.FontFamily, 10, FontStyle.Bold);
            aboutButton.Size = new Size(30, 30);

            // Butonun sabit sağ üst köşede kalması için konumunu ayarlama
            UpdateButtonPosition(panel, aboutButton);
            aboutButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Panelin yeniden boyutlandırılması sırasında butonun konumunu güncelleyin
            panel.Resize += (sender, e) => UpdateButtonPosition(panel, aboutButton);
            panel.ClientSizeChanged += (sender, e) => UpdateButtonPosition(panel, aboutButton);

            aboutButton.Click += (sender, e) => ToggleLabelVisibility(labelInfo);
            panel.Controls.Add(aboutButton);
        }

        private static Label InitializeLabelInfo(Form form)
        {
            Label labelInfo = new Label();
            labelInfo.Text = "Bu uygulama \"Sude Nur Özmen, Burak Güney, Büşra Arslan, Salih Akoğlu, Türkay Aydoğan\" tarafından\r\n tasarlanmış olup, kullanıcıların hastalıklarını bir doktora danışmasına gerek kalmadan\r\n semptomları üzerinden öğrenmesini ve bilgi sahibi olmasını sağlayan bir uygulamadır.\r\n";
            labelInfo.AutoSize = true;

            // Label'ı formun tabanından 30 piksel yukarıda olacak şekilde konumlandırma
            SetLabelInfoPosition(form, labelInfo);

            labelInfo.Visible = false; // Başlangıçta gizli
            form.Controls.Add(labelInfo);

            // Formun yeniden boyutlandırılması durumunda etiketin konumunu güncelleme
            form.Resize += (sender, e) => SetLabelInfoPosition(form, labelInfo);
            form.ClientSizeChanged += (sender, e) => SetLabelInfoPosition(form, labelInfo);

            return labelInfo;
        }

        private static Label InitializeLabelInfo(Panel panel)
        {
            Label labelInfo = new Label();
            labelInfo.Text = "Bu uygulama \"Sude Nur Özmen, Burak Güney, Büşra Arslan, Salih Akoğlu, Türkay Aydoğan\" tarafından\r\n tasarlanmış olup, kullanıcıların hastalıklarını bir doktora danışmasına gerek kalmadan\r\n semptomları üzerinden öğrenmesini ve bilgi sahibi olmasını sağlayan yapay zeka destekli bir uygulamadır.\r\n";
            labelInfo.AutoSize = true;

            // Label'ı panelin tabanından 30 piksel yukarıda olacak şekilde konumlandırma
            SetLabelInfoPosition(panel, labelInfo);

            labelInfo.Visible = false; // Başlangıçta gizli
            panel.Controls.Add(labelInfo);

            // Panelin yeniden boyutlandırılması durumunda etiketin konumunu güncelleme
            panel.Resize += (sender, e) => SetLabelInfoPosition(panel, labelInfo);
            panel.ClientSizeChanged += (sender, e) => SetLabelInfoPosition(panel, labelInfo);

            return labelInfo;
        }

        public static void SetLabelInfoPosition(Form form, Label labelInfo)
        {
            int labelInfoX = (form.ClientSize.Width - labelInfo.Width) / 2;
            int labelInfoY = form.ClientSize.Height - labelInfo.Height - 30;

            labelInfo.Location = new Point(labelInfoX, labelInfoY);
        }

        public static void SetLabelInfoPosition(Panel panel, Label labelInfo)
        {
            int labelInfoX = (panel.ClientSize.Width - labelInfo.Width) / 2; // Ortalanmış X konumu
            int labelInfoY = panel.ClientSize.Height - labelInfo.Height - 30; // Panelin tabanından 30 piksel yukarıda

            labelInfo.Location = new Point(labelInfoX, labelInfoY);
        }

        private static void UpdateButtonPosition(Panel panel, Button aboutButton)
        {
            // Panelin DisplayRectangle özelliği ile butonun sabit sağ üst köşede kalmasını sağlama
            Rectangle displayRect = panel.DisplayRectangle;
            aboutButton.Location = new Point(displayRect.Right - aboutButton.Width - 10, displayRect.Top + 10);
        }

        private static void ToggleLabelVisibility(Label label)
        {
            label.Visible = !label.Visible;
        }
    }
}