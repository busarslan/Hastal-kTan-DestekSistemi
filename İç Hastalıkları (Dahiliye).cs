using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Text;


namespace Hastalik_Tani_Destek_Sistemi
{
    public partial class İçHastalıklarıveDahiliye : Form
    {
        private string userTC;
        private Label baslik;
        private RoundedButton buttonBck;
        private Button btnSave;
        private OneFormToAnother formTransferHelper;


        private const int padding = 10;

        public İçHastalıklarıveDahiliye()
        {
            IconHelper.SetAppIcon(this);
            Program.EnableDoubleBuffering(this);
            InitializeComponent();
            CreateButtonBck();
            CreateButtonSave();
            CreateButtonCheck();
            formTransferHelper = new OneFormToAnother();
            ResizeControls(); // Kontrollerin boyutunu ilk kez ayarla
            this.Load += new EventHandler(İçHastalıklarıveDahiliye_Load); // Form yüklenirken çağrılacak olayı ekle
            this.ClientSize = new Size(800, 450); // Başlangıç boyutlarını ayarla
            this.Resize += new EventHandler(İçHastalıklarıveDahiliye_Resize); // Form yeniden boyutlandırıldığında çağrılacak olayı ekle
            InitializeLabel1();  // alt ana başlık (kulak burun boğaz)
            this.userTC = UserInfo.TCNo;
        }

        private void İçHastalıklarıveDahiliye_Load(object sender, EventArgs e)
        {
            try {
                ResizeControls();
                RepositionControls();
                CustomMenu.AddMenu(this);
                HakkindaButonu.AddAboutButton(this);
                GroupBox.AddGroupBox(this);
                Versiyon.AddVersiyonLabel(this);
            } // Form yüklenirken kontrolleri yeniden konumlandır
            catch { }
        }

        private void İçHastalıklarıveDahiliye_Resize(object sender, EventArgs e)
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
            baslik.Text = "İç Hastalıkları (Dahiliye)";
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
            this.btnSave.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Size = new Size(75, 23);
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
            button.Font = new Font(button.Font.FontFamily, fontSize, FontStyle.Regular); //Super method
        }

        private void RepositionControls()
        {
            baslik.Location = new Point((this.ClientSize.Width - baslik.Width) / 2, (int)(this.ClientSize.Height * 0.05) + 65);


            btnSave.Location = new Point((int)(this.ClientSize.Width - btnSave.Width * 1.1f), (int)(this.ClientSize.Height - btnSave.Height * 1.1f));
            btnCheck.Location = new Point(btnSave.Left, btnSave.Top - btnCheck.Height);


            buttonBck.Location = new Point(padding, this.ClientSize.Height - buttonBck.Height - padding);
            lblResult.Location = new Point(padding, buttonBck.Top - lblResult.Height - padding);


            // checkBox'lar
            int checkBoxTop = baslik.Bottom;
            int checkBoxLeft = (this.ClientSize.Width - chkFever.Width) / 2;
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

                        command.Parameters.AddWithValue("@uzmanlık", "İç Hastalıkları (Dahiliye)");



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
                { "Ateş", chkFever.Checked },
                { "Öksürük", chkCough.Checked },
                { "Halsizlik", chkWeakness.Checked },
                { "Nefes Darlığı", chkShortnessOfBreath.Checked },
                { "Baş Ağrısı", chkHeadache.Checked },
                { "Karın Ağrısı", chkAbdominalPain.Checked },
                { "Kusma", chkVomiting.Checked },
                { "İshal", chkDiarrhea.Checked },
                { "İştah Kaybı", chkLossOfAppetite.Checked },
                { "Bulantı", chkNausea.Checked }
            };

            var diseases = new Dictionary<string, List<string>>
            {
                { "Grip", new List<string> { "Ateş", "Öksürük", "Halsizlik" } },
                { "Pnömoni", new List<string> { "Ateş", "Öksürük", "Nefes Darlığı" } },
                { "Ülser", new List<string> { "Karın Ağrısı", "İshal", "Kusma" } },
                { "Hipertansiyon", new List<string> { "Baş Ağrısı", "Halsizlik" } },
                { "Şeker Hastalığı", new List<string> { "Ateş", "Halsizlik", "İştah Kaybı" } },
                { "Gastroenterit", new List<string> { "Kusma", "İshal", "Nefes Darlığı" } },
                { "Anemi", new List<string> { "Halsizlik", "Baş Ağrısı" } },
                { "Migren", new List<string> { "Baş Ağrısı", "Nefes Darlığı" } },
                { "Ülseratif Kolit", new List<string> { "Karın Ağrısı", "İshal", "Ateş" } },
                { "Kolesistit", new List<string> { "Karın Ağrısı", "Kusma", "Nefes Darlığı" } }
            };
            var selectedSymptoms = symptoms.Where(s => s.Value).Select(s => s.Key).ToList();
            if (selectedSymptoms.Count < 1)
            {
                return "Belirtiler yetersiz, lütfen en az 1 belirti seçin.";
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