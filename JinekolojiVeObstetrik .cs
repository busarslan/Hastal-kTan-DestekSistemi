﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Text;

namespace Hastalik_Tani_Destek_Sistemi
{
    public partial class JinekolojiVeObstetrik : Form
    {
        private string userTC;
        private Label baslik;
        private RoundedButton buttonBck;
        private Button btnSave;
        private OneFormToAnother formTransferHelper;

        private const int padding = 10;

        public JinekolojiVeObstetrik()
        {
            IconHelper.SetAppIcon(this);
            Program.EnableDoubleBuffering(this);
            InitializeComponent();
            CreateButtonBck();
            CreateButtonSave();
            CreateButtonCheck();
            formTransferHelper = new OneFormToAnother();
            btnSave.Click += new EventHandler(btnSave_Click);

            formTransferHelper = new OneFormToAnother();
            ResizeControls(); // Kontrollerin boyutunu ilk kez ayarla
            this.Load += new EventHandler(JinekolojiVeObstetrik_Load); // Form yüklenirken çağrılacak olayı ekle
            this.ClientSize = new Size(800, 450); // Başlangıç boyutlarını ayarla
            this.Resize += new EventHandler(JinekolojiVeObstetrik_Resize); // Form yeniden boyutlandırıldığında çağrılacak olayı ekle
            InitializeLabel1();  // alt ana başlık (kulak burun boğaz) 
          
            Versiyon.AddVersiyonLabel(this);
            this.userTC = UserInfo.TCNo;
        }

        private void JinekolojiVeObstetrik_Load(object sender, EventArgs e)
        {
            try 
            {
                ResizeControls();
                RepositionControls();
                CustomMenu.AddMenu(this);
                HakkindaButonu.AddAboutButton(this);
                GroupBox.AddGroupBox(this);
                Versiyon.AddVersiyonLabel(this);
            } 
            catch { }
        }

        private void JinekolojiVeObstetrik_Resize(object sender, EventArgs e)
        {
            ResizeControls();
            RepositionControls();
            CustomMenu.AddMenu(this);
            HakkindaButonu.AddAboutButton(this);
            GroupBox.AddGroupBox(this);
            Versiyon.AddVersiyonLabel(this);
            this.ClientSize = new Size(Math.Max(this.ClientSize.Width, 800), Math.Max(this.ClientSize.Height, 450)); // Minimum boyutları koru
        }

        private void InitializeLabel1()  // alt alan etiketi
        {
            baslik = new Label();
            baslik.Text = "Jinekoloji ve Obstetrik";
            baslik.AutoSize = true;
            this.baslik.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            baslik.BackColor = Color.Snow;
            this.Controls.Add(baslik);
        }

        private void CreateButtonBck()  // geri butonu
        {
            // Yeni bir buton oluşturma
            buttonBck = new RoundedButton();
            this.buttonBck.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBck.Size = new Size(75, 23);
            buttonBck.Text = " ← ";
            buttonBck.Name = "ButtonBack";
            buttonBck.BackColor = Color.DodgerBlue;
            buttonBck.ForeColor = Color.White;

            // Click olayına bir olay işleyici ekleme
            buttonBck.Click += new EventHandler(MyButton_Click1);

            // Butonu forma ekleme
            this.Controls.Add(buttonBck);
        }

        private void CreateButtonSave()  // Kaydet butonu
        {
            // Yeni bir buton oluşturma
            btnSave = new Button();
            btnSave.Size = new Size(75, 23);
            this.btnSave.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Text = "Kaydet";
            btnSave.Name = "ButtonSave";
            btnSave.BackColor = Color.DodgerBlue;

            // Butonu forma ekleme
            this.Controls.Add(btnSave);
        }
        private void CreateButtonCheck()  // Kaydet butonu
        {
            btnCheck = new Button();  // Create a new button for "Check"
            this.btnCheck.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.Size = new Size(75, 23);
            btnCheck.Text = "Kontrol";
            btnCheck.Name = "ButtonCheck";
            btnCheck.BackColor = Color.DodgerBlue;

            // Adding click event handler
            btnCheck.Click += new EventHandler(btnCheck_Click);

            // Add the button to the form's controls
            this.Controls.Add(btnCheck);
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

            int newWidth = (this.ClientSize.Width);
            int newHeight = (this.ClientSize.Height);

            foreach (Control control in this.Controls)
            {
                if (control is CheckBox)
                {
                    control.Size = new Size(this.ClientSize.Width / 10, this.ClientSize.Height / 10);
                }
                else if (control is Button button)
                {
                    if (button.Name == "ButtonSave" || button.Name == "ButtonCheck")
                    {
                        button.Size = new Size(this.ClientSize.Width / 5, this.ClientSize.Height / 9);
                    }
                }
                else if (control is Label)
                {
                    control.Size = new Size(300, 30);
                }
            }


            lblResult.Size = new Size(this.ClientSize.Width - 2 * padding, 30);

            float clientSizeWidthProp = (float)this.ClientSize.Width;
            float clientSizeHeightProp = (float)this.ClientSize.Height + (float)this.ClientSize.Height / 7;

            ResizeButtonToBottomLeft(buttonBck, clientSizeWidthProp, clientSizeHeightProp - (float)this.ClientSize.Height / 7);

        }

        private void ResizeButtonToBottomLeft(RoundedButton button, float widthProp, float heightProp)
        {
            button.Size = new Size((int)(widthProp / 18), Math.Max((int)(heightProp / 13), 50));
            button.Location = new Point((int)(widthProp / 19), (int)(heightProp - Math.Max((int)(heightProp / 10), 70)));

            float fontSize = button.Width / 5.6f;
            button.Font = new Font(button.Font.FontFamily, fontSize, FontStyle.Regular);
        }

        private void RepositionControls()
        {
            baslik.Location = new Point((this.ClientSize.Width - baslik.Width) / 2, (int)(this.ClientSize.Height * 0.05) + 65);

            btnSave.Location = new Point((int)(this.ClientSize.Width - btnSave.Width * 1.1f), (int)(this.ClientSize.Height - btnSave.Height * 1.1f));
            btnCheck.Location = new Point(btnSave.Left, btnSave.Top - btnCheck.Height);


            buttonBck.Location = new Point(padding, this.ClientSize.Height - buttonBck.Height - padding);
            lblResult.Location = new Point(padding, buttonBck.Top - lblResult.Height - padding);


            int checkBoxTop = baslik.Bottom;
            int checkBoxLeft = (this.ClientSize.Width - chkMenstrualIrregularities.Width) / 2;
            int checkBoxSpacing = 8;
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

                        command.Parameters.AddWithValue("@uzmanlık", "JinekolojiVeObstetrik");



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
                { "Adet Düzensizlikleri", chkMenstrualIrregularities.Checked },
                { "Pelvik Ağrılar", chkPelvicPain.Checked },
                { "Vajinal Kanama", chkVaginalBleeding.Checked },
                { "Vajinal Akıntılar", chkVaginalDischarge.Checked },
                { "Cinsel İlişki Sırasında Ağrı", chkPainDuringIntercourse.Checked },
                { "Göğüs Ağrısı", chkBreastPain.Checked },
                { "Göğüs Kitleleri", chkBreastLump.Checked },
                { "Meme Başından Akıntı", chkNippleDischarge.Checked },
                { "Kısırlık Sorunu", chkInfertility.Checked },
            };

            var diseases = new Dictionary<string, List<string>>
            {
                { "Pelvik İnflamatuvar Hastalık", new List<string> { "Pelvik Ağrılar", "Vajinal Akıntılar", "Vajinal Kanama" } },
                { "Rahim Sarkması", new List<string> { "Pelvik Ağrılar", "Vajinal Akıntılar", "Cinsel İlişki Sırasında Ağrı" } },
                { "Meme Kanseri", new List<string> { "Göğüs Kitleleri", "Meme Başından Akıntı", "Göğüs Ağrısı" } },
                { "Endometriozis", new List<string> { "Pelvik Ağrılar", "Adet Düzensizlikleri" } },
                { "Polikistik Over Sendromu", new List<string> { "Adet Düzensizlikleri", "Kısırlık Sorunu" } }
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
                    result += "Tahmini Durumlar: ";
                    foreach (var disease in bestMatches)
                    {
                        result += disease + ", ";
                    }
                    result = result.TrimEnd(',', ' ');
                }
                else
                {
                    result = "Tahmini Durum: " + bestMatches.First();
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
