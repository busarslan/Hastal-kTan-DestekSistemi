using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hastalik_Tani_Destek_Sistemi
{
    public partial class alan_secim : Form
    {
        private Label[] columnLabels;
        private string[] labelTexts = { "Dahili Tıp Bilimleri", "Cerrahi Tıp Bilimleri" };
        private PictureBox pictureBox;
        private Label kullaniciLabel;
        private Button backButton;
        private CustomButton BeyinveSinirCerrahi;
        private CustomButton ÇocukCerrahisi;
        private CustomButton Dermatoloji;
        private CustomButton EndokrinolojiveMetabolizma;
        private CustomButton EnfeksiyonHastalıkları;
        private CustomButton FizikTedavi;
        private CustomButton Gastroenteroloji;
        private CustomButton GenelCerrahi;
        private CustomButton GöğüsCerrahi;
        private CustomButton GöğüsHastalıkları;
        private CustomButton GözHastalıkları;
        private CustomButton Hematoloji;
        private CustomButton İçHastalıkları;
        private CustomButton JinekolojiVeObstetrik;
        private CustomButton KalpveDamarCerrahisi;
        private CustomButton Kardiyoloji;
        private CustomButton KulakBurunBoğaz;
        private CustomButton Nefroloji;
        private CustomButton Nöroloji;
        private CustomButton Onkoloji;
        private CustomButton Psikiyatri;
        private CustomButton Romatoloji;
        private CustomButton Üroloji;
        private OneFormToAnother formTransferHelper;


        private List<CustomButton> customButtons;
        private Dictionary<CustomButton, Point> buttonInitialLocations;
        private Dictionary<CustomButton, Size> buttonInitialSizes;
        private Dictionary<CustomButton, float> buttonInitialFontSizes;

        public alan_secim()
        {
            InitializeComponent();
            InitializeLabel();
            InitializeColumnLabels();
            InitializePictureBox();
            CustomMenu.AddMenu(this);
            CustomMenu.AddMenu(this.panel1);
            HakkindaButonu.AddAboutButton(this);
            HakkindaButonu.AddAboutButton(this.panel1);
            GroupBox.AddGroupBox(this);
            GroupBox.AddGroupBox(this.panel1);
            Program.EnableDoubleBuffering(this);
            Program.EnableDoubleBuffering(this.panel1);
            CreateBackButton();
            CreateCustomButtons();
            formTransferHelper = new OneFormToAnother();
            this.Resize += new EventHandler(Form1_Resize);
            this.ClientSize = new Size(Math.Max(this.ClientSize.Width, 800), Math.Max(this.ClientSize.Height, 450));
            

            StoreInitialPositions();
            RepositionControls();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.ClientSize = new Size(Math.Max(this.ClientSize.Width, 800), Math.Max(this.ClientSize.Height, 450));
            RepositionControls();
        }

        private void InitializePictureBox()
        {
            pictureBox = new PictureBox
            {
                Size = new Size(80, 80),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            panel1.Controls.Add(pictureBox);

                pictureBox.Image = Hastalik_Tani_Destek_Sistemi.Properties.Resources.BlankProfilePicture;

            pictureBox.Paint += new PaintEventHandler(PictureBox_Paint);
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            if (picBox.Image != null)
            {
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, picBox.Width, picBox.Height);
                picBox.Region = new Region(path);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.SetClip(path);
                e.Graphics.DrawImage(picBox.Image, 0, 0, picBox.Width, picBox.Height);
            }
        }

        private void InitializeColumnLabels()
        {
            columnLabels = new Label[2];

            for (int i = 0; i < 2; i++)
            {
                columnLabels[i] = new Label
                {
                    BorderStyle = BorderStyle.Fixed3D,
                    Text = labelTexts[i],
                    Font = new Font("Arial", 20),
                    AutoSize = true,
                    BackColor = Color.Snow,
                };
                panel1.Controls.Add(columnLabels[i]);
            }
        }

        private void InitializeLabel()
        {
            // kullaniciLabel etiketini oluşturun
            kullaniciLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Arial", 20),
                BackColor = Color.Snow,
            };

            // UserInfo sınıfından TCNo'yu alarak veritabanında ilgili hastanın isim ve soyisim bilgilerini getirin
            string tcNo = UserInfo.TCNo;
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\busbu\source\repos\Bgenone\HTDSnew\hastaneproje.accdb";
            string query = "SELECT isim, soyisim FROM hastalar WHERE TCNo = @TCNo";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TCNo", tcNo);
                        OleDbDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            // Veritabanından alınan isim ve soyisim bilgilerini kullanarak etiketin metnini oluşturun
                            string isim = reader.GetString(0);
                            string soyisim = reader.GetString(1);
                            kullaniciLabel.Text = $"{isim} {soyisim}";
                        }
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

            // Panel içine etiketi ekleyin
            panel1.Controls.Add(kullaniciLabel);
        }

        private void CreateBackButton()
        {
            backButton = new Button
            {
                Size = new Size(50, 50),
                Text = " ← ",
                Name = "ButtonBack"
            };
            backButton.Click += new EventHandler(BackButton_Click);
            panel1.Controls.Add(backButton);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            PatientLogPage ptn_LP = new PatientLogPage();
            formTransferHelper.TransferSizeAndLocation(this, ptn_LP);
            this.Hide();
            ptn_LP.ShowDialog();
            this.Close();
        }

        private void CreateCustomButtons()
        {
            customButtons = new List<CustomButton>();
            buttonInitialLocations = new Dictionary<CustomButton, Point>();
            buttonInitialSizes = new Dictionary<CustomButton, Size>();
            buttonInitialFontSizes = new Dictionary<CustomButton, float>();

            BeyinveSinirCerrahi = new CustomButton("Beyin Cerrahisi", "BeyinveSinirCerrahi", new Point(460, 150), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(BeyinveSinirCerrahi);
            panel1.Controls.Add(BeyinveSinirCerrahi);

            ÇocukCerrahisi = new CustomButton("Çocuk Cerrahisi", "ÇocukCerrahisi", new Point(460, 210), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(ÇocukCerrahisi);
            panel1.Controls.Add(ÇocukCerrahisi);

            Dermatoloji = new CustomButton("Dermatoloji", "Dermatoloji", new Point(195, 150), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(Dermatoloji);
            panel1.Controls.Add(Dermatoloji);

            EndokrinolojiveMetabolizma = new CustomButton("Endokrinoloji ve Metabolizma Hastalıkları", "EndokrinolojiveMetabolizma", new Point(195, 210), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(EndokrinolojiveMetabolizma);
            panel1.Controls.Add(EndokrinolojiveMetabolizma);

            EnfeksiyonHastalıkları = new CustomButton("Enfeksiyon Hastalıkları", "EnfeksiyonHastalıkları", new Point(195, 270), new Size(170, 50))
            {
                ForeColor = Color.Snow,
                BackColor = Color.DodgerBlue
            };
            customButtons.Add(EnfeksiyonHastalıkları);
            panel1.Controls.Add(EnfeksiyonHastalıkları);

            FizikTedavi = new CustomButton("Fiziksel Tıp ve Rehabilitasyon ", "FizikTedavi", new Point(195, 330), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(FizikTedavi);
            panel1.Controls.Add(FizikTedavi);

            Gastroenteroloji = new CustomButton("Gastroentoloji", "Gastroenteroloji", new Point(195, 390), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(Gastroenteroloji);
            panel1.Controls.Add(Gastroenteroloji);

            GenelCerrahi = new CustomButton("Genel Cerrahi", "GenelCerrahi", new Point(460, 270), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(GenelCerrahi);
            panel1.Controls.Add(GenelCerrahi);

            GöğüsCerrahi = new CustomButton("Göğüs Cerrahisi", "GöğüsCerrahi", new Point(460, 330), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(GöğüsCerrahi);
            panel1.Controls.Add(GöğüsCerrahi);

            GöğüsHastalıkları = new CustomButton("Göğüs Hastalıkları", "GöğüsHastalıkları", new Point(195, 450), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(GöğüsHastalıkları);
            panel1.Controls.Add(GöğüsHastalıkları);

            GözHastalıkları = new CustomButton("Göz Hastalıkları", "GözHastalıkları", new Point(195, 510), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(GözHastalıkları);
            panel1.Controls.Add(GözHastalıkları);

            Hematoloji = new CustomButton("Hematoloji ", "Hematoloji", new Point(195, 570), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(Hematoloji);
            panel1.Controls.Add(Hematoloji);

            İçHastalıkları = new CustomButton("İç Hastalıkları", "İçHastalıklarıveDahiliye", new Point(195, 630), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(İçHastalıkları);
            panel1.Controls.Add(İçHastalıkları);

            JinekolojiVeObstetrik = new CustomButton("Kadın Hastalıkları ve Doğum", "JinekolojiVeObstetrik", new Point(460, 390), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(JinekolojiVeObstetrik);
            panel1.Controls.Add(JinekolojiVeObstetrik);

            KalpveDamarCerrahisi = new CustomButton("Kalp ve Damar Cerrahisi", "KalpveDamarCerrahisi", new Point(460, 450), new Size(170, 50))
            {
                ForeColor = Color.Snow,
                BackColor = Color.DodgerBlue
            };
            customButtons.Add(KalpveDamarCerrahisi);
            panel1.Controls.Add(KalpveDamarCerrahisi);

            Kardiyoloji = new CustomButton("Kardiyoloji", "Kardiyoloji", new Point(195, 690), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(Kardiyoloji);
            panel1.Controls.Add(Kardiyoloji);

            KulakBurunBoğaz = new CustomButton("Kulak Burun Boğaz Hastalıkları", "KulakBurunBoğaz", new Point(195, 750), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(KulakBurunBoğaz);
            panel1.Controls.Add(KulakBurunBoğaz);

            Nefroloji = new CustomButton("Nefroloji", "Nefroloji", new Point(195, 810), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(Nefroloji);
            panel1.Controls.Add(Nefroloji);

            Nöroloji = new CustomButton("Nöroloji", "Nöroloji", new Point(195, 870), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(Nöroloji);
            panel1.Controls.Add(Nöroloji);

            Onkoloji = new CustomButton("Onkoloji", "Onkoloji", new Point(195, 930), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(Onkoloji);
            panel1.Controls.Add(Onkoloji);

            Psikiyatri = new CustomButton("Psikiyatri", "Psikiyatri", new Point(195, 990), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(Psikiyatri);
            panel1.Controls.Add(Psikiyatri);

            Romatoloji = new CustomButton("Romatoloji", "Romatoloji", new Point(195, 1050), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(Romatoloji);
            panel1.Controls.Add(Romatoloji);

            Üroloji = new CustomButton("Üroloji", "Üroloji", new Point(460, 510), new Size(170, 50))
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.Snow
            };
            customButtons.Add(Üroloji);
            panel1.Controls.Add(Üroloji);
        }

        private void StoreInitialPositions()
        {
            foreach (CustomButton button in customButtons)
            {
                buttonInitialLocations[button] = button.Location;
                buttonInitialSizes[button] = button.Size;
                buttonInitialFontSizes[button] = button.Font.Size;
            }
        }

        private void RepositionControls()
        {
            float widthFactor = (float)ClientSize.Width / 800;
            float heightFactor = (float)ClientSize.Height / 450;

            int topMargin = (int)(50 * heightFactor); // Kullanıcı label'ı için
            int pictureBoxHeight = (int)(90 * heightFactor); // PictureBox için
            topMargin += pictureBoxHeight + (int)(10 * heightFactor);

            foreach (CustomButton button in customButtons)
            {
                Point initialLocation = buttonInitialLocations[button];
                Size initialSize = buttonInitialSizes[button];
                float initialFontSize = buttonInitialFontSizes[button];

                int newX = (int)(initialLocation.X * widthFactor);
                int newY = (int)(initialLocation.Y * heightFactor);
                int newWidth = (int)(initialSize.Width * widthFactor);
                int newHeight = (int)(initialSize.Height * heightFactor);

                button.Location = new Point(newX, newY);
                button.Size = new Size(newWidth, newHeight);

                float newFontSize = initialFontSize * Math.Min(widthFactor, heightFactor);
                button.Font = new Font(button.Font.FontFamily, newFontSize);
            }

            int kullaniciLabelX = (int)(140 * widthFactor);
            int kullaniciLabelY = (int)(50 * heightFactor);
            kullaniciLabel.Location = new Point(kullaniciLabelX, kullaniciLabelY);
            kullaniciLabel.Font = new Font(kullaniciLabel.Font.FontFamily, 20 * Math.Min(widthFactor, heightFactor));

            int pictureBoxX = (int)(30 * widthFactor);
            int pictureBoxY = (int)(50 * heightFactor);
            pictureBox.Location = new Point(pictureBoxX, pictureBoxY);

            for (int i = 0; i < columnLabels.Length; i++)
            {
                int columnLabelX = (int)((170 + 280 * i) * widthFactor);
                int columnLabelY = (int)(100 * heightFactor);
                columnLabels[i].Location = new Point(columnLabelX-60, columnLabelY);
                columnLabels[i].Font = new Font(columnLabels[i].Font.FontFamily, 20 * Math.Min(widthFactor, heightFactor));
            }

            int backButtonX = (int)(25 * widthFactor);
            int backButtonY = (int)(1100 * heightFactor);
            backButton.Location = new Point(backButtonX, backButtonY);


            Versiyon.AddVersiyonLabel(this);

        }
    }
}


    public class CustomButton : Button
    {
        public CustomButton(string text, string name, Point location, Size size)
        {
            this.Text = text;
            this.Name = name;
            this.Location = location;
            this.Size = size;
        }
    }

namespace Hastalik_Tani_Destek_Sistemi
{
    partial class alan_secim
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel1 = new Panel();
            this.panel1.BackgroundImage = Hastalik_Tani_Destek_Sistemi.Properties.Resources.GeneralBackground;
            this.panel1.BackgroundImageLayout = ImageLayout.Stretch;
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);  // Updated
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(this.ClientSize.Width, this.ClientSize.Height);  // Updated
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Hastalık Tanı Destek Sistemi - Alan Seçim Sayfası";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
        }
    }
}