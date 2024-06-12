using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Text;

namespace Hastalik_Tani_Destek_Sistemi
{
    public partial class OrtopediveTravmatoloji : Form
    {
        private string userTC;
        private Label baslik;
        private RoundedButton buttonBck;
        private Button btnSave;
        private OneFormToAnother formTransferHelper;

        private const int padding = 10; // Kontrol kenar boşluğu

        public OrtopediveTravmatoloji()
        {
            CustomMenu.AddMenu(this);
            IconHelper.SetAppIcon(this);
            Program.EnableDoubleBuffering(this);
            InitializeComponent();
            CreateButtonBck();
            CreateButtonSave();
            btnSave.Click += new EventHandler(btnSave_Click);

            formTransferHelper = new OneFormToAnother();
            ResizeControls(); // Kontrollerin boyutunu ilk kez ayarla
            this.Load += new EventHandler(OrtopediveTravmatoloji_Load); // Form yüklenirken çağrılacak olayı ekle
            this.ClientSize = new Size(800, 450); // Başlangıç boyutlarını ayarla
            this.Resize += new EventHandler(OrtopediveTravmatoloji_Resize); // Form yeniden boyutlandırıldığında çağrılacak olayı ekle
            InitializeLabel1();  // alt ana başlık (kulak burun boğaz) 
         
            Versiyon.AddVersiyonLabel(this);
            this.userTC = UserInfo.TCNo;
        }

        private void OrtopediveTravmatoloji_Load(object sender, EventArgs e)
        {
            try { RepositionControls(); } // Form yüklenirken kontrolleri yeniden konumlandır
            catch { }
        }

        private void OrtopediveTravmatoloji_Resize(object sender, EventArgs e)
        {
            RepositionControls();
            this.ClientSize = new Size(Math.Max(this.ClientSize.Width, 800), Math.Max(this.ClientSize.Height, 450)); // Minimum boyutları koru
        }

        private void InitializeLabel1()  // alt alan etiketi
        {
            baslik = new Label();
            baslik.Text = "Ortopedi ve Travmatoloji";
            baslik.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            baslik.AutoSize = true;
            baslik.BackColor = Color.Snow;
            this.Controls.Add(baslik);
        }

        private void CreateButtonBck()  // geri butonu
        {
            // Yeni bir buton oluşturma
            buttonBck = new RoundedButton();
            buttonBck.Size = new Size(75, 23);
            buttonBck.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBck.Text = " ← ";
            buttonBck.Name = "ButtonBack";
            buttonBck.BackColor = Color.DodgerBlue;

            // Click olayına bir olay işleyici ekleme
            buttonBck.Click += new EventHandler(MyButton_Click1);

            // Butonu forma ekleme
            this.Controls.Add(buttonBck);
        }

        private void CreateButtonSave()  // Kaydet butonu
        {
            // Yeni bir buton oluşturma
            btnSave = new Button();
            btnSave.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Size = new Size(75, 23);
            btnSave.Text = "Kaydet";
            btnSave.Name = "ButtonSave";
            btnSave.BackColor = Color.DodgerBlue;

            // Butonu forma ekleme
            this.Controls.Add(btnSave);
        }

        private void MyButton_Click1(object sender, EventArgs e)  // geri butonu
        {
            alan_secim geri = new alan_secim();
            formTransferHelper.TransferSizeAndLocation(this, geri);
            this.Hide();
            geri.ShowDialog();
            if (geri.DialogResult == DialogResult.OK) { }
            this.Close();
        }

        private void ResizeControls()
        {
            // CheckBox'ların ve Button'ların yeni boyutunu hesapla
            int newWidth = (this.ClientSize.Width - 2 * padding); // Sadece bir sütun olacak şekilde CheckBox'ların ve Button'ların genişliği
            int newHeight = (this.ClientSize.Height - 6 * padding) / 7; // 7 satır için CheckBox'ların ve Button'ların yüksekliği

            foreach (Control control in this.Controls)
            {
                if (control is CheckBox)
                {
                    control.Size = new Size(newWidth, newHeight);
                }
                else if (control is Button)
                {
                    control.Size = new Size(75, 23); // Butonların boyutunu ayarla
                }
                else if (control is Label)
                {
                    // Label'ın boyutunu ve konumunu ayarla
                    control.Size = new Size(300, 30);
                }
            }

            // "lblResult" Label'ının boyutunu ve konumunu ayarla
            lblResult.Size = new Size(this.ClientSize.Width - 2 * padding, 30);


            float clientSizeWidthProp = (float)this.ClientSize.Width;
            float clientSizeHeightProp = (float)this.ClientSize.Height + (float)this.ClientSize.Height / 7; // Böyle yapılabilir nfdıaaaaaaaaaaaaaa

            ResizeButtonToBottomLeft(buttonBck, clientSizeWidthProp, clientSizeHeightProp - (float)this.ClientSize.Height / 7);
        }

        private void ResizeButtonToBottomLeft(RoundedButton button, float widthProp, float heightProp)
        {
            button.Size = new Size((int)(widthProp / 18), Math.Max((int)(heightProp / 13), 50));
            button.Location = new Point((int)(widthProp / 19), (int)(heightProp - Math.Max((int)(heightProp / 10), 70)));

            float fontSize = button.Width / 5.6f;
            button.Font = new Font(button.Font.FontFamily, fontSize, FontStyle.Regular); //Super method
        }

        private void RepositionControls()
        {
            // baslik
            baslik.Location = new Point((this.ClientSize.Width - baslik.Width) / 2, (int)(this.ClientSize.Height * 0.05));

            // btnSave
            btnSave.Location = new Point(this.ClientSize.Width - btnSave.Width - padding, this.ClientSize.Height - btnSave.Height - padding);

            // buttonBck
            buttonBck.Location = new Point(padding, this.ClientSize.Height - buttonBck.Height - padding);

            // lblResult
            lblResult.Location = new Point(padding, buttonBck.Top - lblResult.Height - padding);


            // btnCheck
            btnCheck.Location = new Point(btnSave.Left, btnSave.Top - btnCheck.Height - padding);

            // checkBox'lar
            int checkBoxTop = baslik.Bottom + padding;
            int checkBoxLeft = (this.ClientSize.Width - chkSwelling.Width) / 2;
            int checkBoxSpacing = 5;
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox)
                {
                    control.Location = new Point(checkBoxLeft, checkBoxTop);
                    checkBoxTop += control.Height + checkBoxSpacing;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\busbu\\source\\repos\\Bgenone\\HTDSnew\\hastaneproje.accdb";
            string query = "UPDATE hastalar SET uzmanlık = @uzmanlık WHERE TCNo = @TCNo";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (OleDbCommand command = new OleDbCommand(query, conn))
                    {

                        command.Parameters.AddWithValue("@uzmanlık", "Ortopedi ve Travmatoloji");

                        command.Parameters.AddWithValue("@TCNo", userTC);

                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Veritabanı bağlantısında bir hata oluştu: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message);
                }
            }
            string query1 = "UPDATE hastalar SET hastalık = @hastalık WHERE TCNo = @TCNo";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query1, conn))
                {
                    conn.Open();
                    command.Parameters.AddWithValue("@hastalık", lblResult.Text);
                    command.Parameters.AddWithValue("@TCNo", userTC);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string possibleDiseases = DetermineDiseases();
            lblResult.Text = possibleDiseases;
        }
        private string DetermineDiseases()
        {
            var symptoms = new Dictionary<string, bool>
            {
                { "Şişlik", chkSwelling.Checked },
                { "Ağrı", chkPain.Checked },
                { "Kızarıklık", chkRedness.Checked },
                { "Hareket Kısıtlılığı", chkMovementLimitation.Checked },
                { "Morarma", chkBruising.Checked },
                { "Deformite", chkDeformity.Checked },
                { "Uyuşma", chkNumbness.Checked },
                { "Karıncalanma", chkTingling.Checked },
                { "Eklem Kilitlenmesi", chkJointLocking.Checked },
                { "Eklem Sertliği", chkJointStiffness.Checked }
            };

            var diseases = new Dictionary<string, List<string>>
            {
                { "Kemik Kırığı", new List<string> { "Şişlik", "Ağrı", "Hareket Kısıtlılığı", "Morarma", "Deformite" } },
                { "Çıkık", new List<string> { "Şişlik", "Ağrı", "Deformite", "Hareket Kısıtlılığı" } },
                { "Burkulma", new List<string> { "Şişlik", "Ağrı", "Morarma", "Hareket Kısıtlılığı" } },
                { "Tendonit", new List<string> { "Şişlik", "Ağrı", "Kızarıklık", "Hareket Kısıtlılığı" } },
                { "Menisküs Yırtığı", new List<string> { "Şişlik", "Ağrı", "Hareket Kısıtlılığı", "Eklem Kilitlenmesi" } },
                { "Artrit", new List<string> { "Şişlik", "Ağrı", "Kızarıklık", "Hareket Kısıtlılığı", "Eklem Sertliği" } },
                { "Bursit", new List<string> { "Şişlik", "Ağrı", "Kızarıklık", "Hareket Kısıtlılığı" } },
                { "Karpal Tünel Sendromu", new List<string> { "Şişlik", "Ağrı", "Uyuşma", "Karıncalanma", "Hareket Kısıtlılığı" } },
                { "Kırık Çıkık", new List<string> { "Şişlik", "Ağrı", "Morarma", "Deformite", "Hareket Kısıtlılığı" } },
                { "Kas Yırtılması", new List<string> { "Şişlik", "Ağrı", "Morarma", "Hareket Kısıtlılığı" } }
            };

            var selectedSymptoms = symptoms.Where(s => s.Value).Select(s => s.Key).ToList();
            if (selectedSymptoms.Count < 3)
            {
                return "Belirtiler yetersiz, lütfen en az 3 belirti seçin.";
            }

            var diseaseScores = new Dictionary<string, double>();

            foreach (var disease in diseases)
            {
                var matchedSymptoms = disease.Value.Intersect(selectedSymptoms).Count();
                var score = (double)matchedSymptoms / disease.Value.Count;
                diseaseScores[disease.Key] = score;
            }

            var maxScore = diseaseScores.Max(kv => kv.Value);
            var bestMatches = diseaseScores.Where(kv => kv.Value == maxScore).Select(kv => kv.Key);

            if (maxScore > 0)
            {
                string result = "";
                if (bestMatches.Count() > 1)
                {
                    result += "Tahmini Hastalıklar: ";
                    foreach (var disease in bestMatches)
                    {
                        result += disease + ", ";
                    }
                    result = result.TrimEnd(',', ' ');
                }
                else
                {
                    result = "Tahmini Hastalık: " + bestMatches.First();
                }
                result += $" (%{maxScore * 100:F2} uyum)";
                return result;
            }
            else
            {
                return "Belirtiler yetersiz, lütfen bir doktora danışın.";
            }
        }
    }
}