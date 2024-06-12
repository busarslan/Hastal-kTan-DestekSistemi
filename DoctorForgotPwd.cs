using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Hastalik_Tani_Destek_Sistemi
{
    public partial class DoctorForgotPwd : Form
    {
        private OleDbConnection conn;
        private OleDbCommand cmd;
        private OneFormToAnother formTransferHelper;

        public DoctorForgotPwd()
        {
            IconHelper.SetAppIcon(this);
            Program.EnableDoubleBuffering(this);
            formTransferHelper = new OneFormToAnother();
            InitializeComponent();
            CustomMenu.AddMenu(this);
            HakkindaButonu.AddAboutButton(this);
            Versiyon.AddVersiyonLabel(this);
            GroupBox.AddGroupBox(this);
            BtnGuncelleDFP.Click += new EventHandler(BtnGuncelleDFP_Click);
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\busbu\\source\\repos\\Bgenone\\HTDSnew\\hastaneproje.accdb";
            conn = new OleDbConnection(connectionString);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.Resize += new EventHandler(DoctorForgotPwd_Resize);
            this.Load += new EventHandler(DoctorForgotPwd_Load);



            BtnVazgecDFP = new Button();
            TxtSfreDFP = new TextBox();
            TxtSfreDFP2 = new TextBox();
            TxtTCDFP = new TextBox();
            YeniSifreLabelDFP = new Label();
            YeniSifreLabelDFP2 = new Label();
            TcLabelDFP = new Label();
            BtnGuncelleDFP = new Button();
            SuspendLayout();

            // BtnVazgecDFP
            BtnVazgecDFP.BackColor = Color.DodgerBlue;
            BtnVazgecDFP.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVazgecDFP.ForeColor = SystemColors.InactiveBorder;
            BtnVazgecDFP.Location = new Point(308, 450);
            BtnVazgecDFP.Name = "BtnVazgecDFP";
            BtnVazgecDFP.Size = new Size(181, 62);
            BtnVazgecDFP.Margin = new Padding(2);
            BtnVazgecDFP.TabIndex = 26;
            BtnVazgecDFP.Text = "Vazgeç";
            BtnVazgecDFP.UseVisualStyleBackColor = false;
            BtnVazgecDFP.Click += BtnVazgecDFP_Click;

            // TxtSfreDFP 
            TxtSfreDFP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSfreDFP.Location = new Point(10, 206);
            TxtSfreDFP.Name = "TxtSfreDFP";
            TxtSfreDFP.Margin = new Padding(2);
            TxtSfreDFP.PasswordChar = '*';
            TxtSfreDFP.Size = new Size(377, 32);
            TxtSfreDFP.TabIndex = 25;

            // TxtSfreDFP2 
            TxtSfreDFP2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSfreDFP2.Location = new Point(213, 303);
            TxtSfreDFP2.Margin = new Padding(2);
            TxtSfreDFP2.Name = "TxtSfreDFP2";
            TxtSfreDFP2.PasswordChar = '*';
            TxtSfreDFP2.Size = new Size(377, 32);
            TxtSfreDFP2.TabIndex = 20;

            // TxtTCDFP 
            TxtTCDFP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTCDFP.Location = new Point(213, 109);
            TxtTCDFP.Name = "TxtTCDFP";
            TxtTCDFP.Margin = new Padding(2);
            TxtTCDFP.Size = new Size(377, 32);
            TxtTCDFP.TabIndex = 24;

            // YeniSifreLabelDFP 
            YeniSifreLabelDFP.AutoSize = true;
            YeniSifreLabelDFP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YeniSifreLabelDFP.Location = new Point(207, 172);
            YeniSifreLabelDFP.Name = "YeniSifreLabelDFP";
            YeniSifreLabelDFP.Margin = new Padding(2, 0, 2, 0);
            YeniSifreLabelDFP.Size = new Size(95, 24);
            YeniSifreLabelDFP.TabIndex = 23;
            YeniSifreLabelDFP.Text = "Yeni Şifre";

            // YeniSifreLabelDFP2 
            YeniSifreLabelDFP2.AutoSize = true;
            YeniSifreLabelDFP2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YeniSifreLabelDFP2.Location = new Point(207, 269);
            YeniSifreLabelDFP2.Margin = new Padding(2, 0, 2, 0);
            YeniSifreLabelDFP2.Name = "YeniSifreLabelDFP2";
            YeniSifreLabelDFP2.Size = new Size(95, 24);
            YeniSifreLabelDFP2.TabIndex = 18;
            YeniSifreLabelDFP2.Text = "Şifre Tekrar";

            // TcLabelDFP
            TcLabelDFP.AutoSize = true;
            TcLabelDFP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TcLabelDFP.ForeColor = Color.Black;
            TcLabelDFP.Location = new Point(207, 75);
            TcLabelDFP.Name = "TcLabelDFP";
            TcLabelDFP.Margin = new Padding(2, 0, 2, 0);
            TcLabelDFP.Size = new Size(136, 24);
            TcLabelDFP.TabIndex = 22;
            TcLabelDFP.Text = "T.C. Kimlik No";

            // BtnGuncelleDFP 
            BtnGuncelleDFP.BackColor = Color.DodgerBlue;
            BtnGuncelleDFP.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuncelleDFP.ForeColor = SystemColors.InactiveBorder;
            BtnGuncelleDFP.Location = new Point(213, 370);
            BtnGuncelleDFP.Name = "BtnGuncelleDFP";
            BtnGuncelleDFP.Size = new Size(379, 62);
            BtnGuncelleDFP.Margin = new Padding(2);
            BtnGuncelleDFP.TabIndex = 21;
            BtnGuncelleDFP.Text = "Güncelle";
            BtnGuncelleDFP.UseVisualStyleBackColor = false;
            BtnGuncelleDFP.Click += BtnGuncelleDFP_Click;

            // DoctorForgotPwd 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 854);
            Controls.Add(BtnVazgecDFP);
            Controls.Add(TxtSfreDFP);
            Controls.Add(TxtSfreDFP2);
            Controls.Add(TxtTCDFP);
            Controls.Add(YeniSifreLabelDFP);
            Controls.Add(YeniSifreLabelDFP2);
            Controls.Add(TcLabelDFP);
            Controls.Add(BtnGuncelleDFP);
            Margin = new Padding(2);
            Name = "DoctorForgotPwd";
            Text = "Hastalık Tanı Destek Sistemi - Şifremi Unuttum (Dr)";

            // Arka plan resmini ekleyin
            this.BackgroundImage = Hastalik_Tani_Destek_Sistemi.Properties.Resources.GeneralBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnVazgecDFP;
        private TextBox TxtSfreDFP;
        private TextBox TxtSfreDFP2;
        private TextBox TxtTCDFP;
        private Label YeniSifreLabelDFP;
        private Label YeniSifreLabelDFP2;
        private Label TcLabelDFP;
        private Button BtnGuncelleDFP;

        private void DoctorForgotPwd_Load(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void DoctorForgotPwd_Resize(object sender, EventArgs e)
        {
            this.ClientSize = new Size(Math.Max(this.ClientSize.Width, 800), Math.Max(this.ClientSize.Height, 450));
            ResizeControls();
        }

        private void ResizeControls()
        {

            float clientSizeWidthProp = this.ClientSize.Width;
            float clientSizeHeightProp = this.ClientSize.Height;

            ResizeButton(BtnGuncelleDFP, clientSizeWidthProp, clientSizeHeightProp, 2.1f);
            ResizeButton(BtnVazgecDFP, clientSizeWidthProp, clientSizeHeightProp, 1.75f);

            ResizeLabel_TextBox(TcLabelDFP, clientSizeWidthProp, clientSizeHeightProp, 7.5f, 0, TxtTCDFP);
            ResizeLabel_TextBox(YeniSifreLabelDFP, clientSizeWidthProp, clientSizeHeightProp, 6.25f, TcLabelDFP.Height, TxtSfreDFP);
            ResizeLabel_TextBox(YeniSifreLabelDFP2, clientSizeWidthProp, clientSizeHeightProp, 5f, TcLabelDFP.Height * 1.8f, TxtSfreDFP2);


            ResizeTextBox(TxtTCDFP, clientSizeWidthProp, clientSizeHeightProp, TcLabelDFP);
            ResizeTextBox(TxtSfreDFP, clientSizeWidthProp, clientSizeHeightProp, YeniSifreLabelDFP);
            ResizeTextBox(TxtSfreDFP2, clientSizeWidthProp, clientSizeHeightProp, YeniSifreLabelDFP2);

            Versiyon.AddVersiyonLabel(this);
        }
        private void ResizeButton(Button button, float widthProp, float heightProp, float yaxis)
        {
            button.Size = new Size((int)(widthProp / 5), (int)(heightProp / 13.8));
            button.Location = new Point((this.ClientSize.Width - button.Width) / 2, (int)(65 + (heightProp / yaxis)));

            float fontSize = button.Height / 3.8f;
            button.Font = new Font(button.Font.FontFamily, fontSize, FontStyle.Regular);
        }
        private void ResizeLabel_TextBox(Label label, float widthProp, float heightProp, float yaxis, float abc, TextBox textbox1)
        {
            float labelWidth = widthProp / 10;
            float labelHeight = heightProp / 20;
            label.Size = new Size((int)labelWidth, (int)labelHeight);
            label.Location = new Point((int)(widthProp/7.5f), (int)(65 + abc + (heightProp / yaxis)));

            float fontSize = labelHeight / 1.8f;
            label.Font = new Font(label.Font.FontFamily, fontSize, FontStyle.Regular);
        }
        private void ResizeTextBox(TextBox textBox1, float widthProp, float heightProp, Label CurrentLabel)
        {
            textBox1.Size = new Size((int)(widthProp / 3.5f), (int)(heightProp / 4f));
            textBox1.Height = (int)(heightProp / 12);
            textBox1.Left = ((int)((widthProp - textBox1.Width) / 2));
            textBox1.Top = CurrentLabel.Top + 3;
        }
        private void BtnGuncelleDFP_Click(object sender, EventArgs e)
        {
            string tcNo = TxtTCDFP.Text;
            string yeniSifre = TxtSfreDFP.Text;
            string yeniSifreTekrar = TxtSfreDFP2.Text;

            if (yeniSifre != yeniSifreTekrar)
            {
                MessageBox.Show("Girilen şifreler aynı değil. Lütfen tekrar deneyin.");
                return;
            }

            if (!SifreKriterleriniKontrolEt(yeniSifre))
            {
                MessageBox.Show("Şifre en az 8 karakter uzunluğunda, bir büyük harf ve bir özel karakter içermelidir.");
                return;
            }

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\sprin\\source\\repos\\Bgenone\\HTDS\\hastaneproje.accdb";

            string queryCheckUser = "SELECT COUNT(*) FROM doktorlar WHERE TCNo = ?";
            string queryUpdatePassword = "UPDATE doktorlar SET sifre = ? WHERE TCNo = ?";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OleDbCommand commandCheckUser = new OleDbCommand(queryCheckUser, connection))
                    {
                        commandCheckUser.Parameters.Add(new OleDbParameter("TCNo", tcNo));

                        object result = commandCheckUser.ExecuteScalar();
                        int userCount = result != null ? Convert.ToInt32(result) : 0;

                        if (userCount > 0)
                        {
                            using (OleDbCommand commandUpdatePassword = new OleDbCommand(queryUpdatePassword, connection))
                            {
                                commandUpdatePassword.Parameters.Add(new OleDbParameter("sifre", yeniSifre));
                                commandUpdatePassword.Parameters.Add(new OleDbParameter("TCNo", tcNo));

                                int rowsAffected = commandUpdatePassword.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Şifreniz başarıyla güncellendi.");
                                }
                                else
                                {
                                    MessageBox.Show("Şifre güncellenemedi. Lütfen tekrar deneyin.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bu TC No ile kayıtlı kullanıcı bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantısında bir hata oluştu: " + ex.Message);
                }
            }
        }
        public bool SifreKriterleriniKontrolEt(string sifre)
        {
            if (sifre.Length < 8)
                return false;

            bool buyukHarfVar = false;
            bool ozelKarakterVar = false;

            foreach (char c in sifre)
            {
                if (char.IsUpper(c))
                    buyukHarfVar = true;

                if (!char.IsLetterOrDigit(c))
                    ozelKarakterVar = true;

                if (buyukHarfVar && ozelKarakterVar)
                    return true;
            }

            return false;
        }
        public void BtnVazgecDFP_Click(object sender, EventArgs e)
        {
            DoctorLogPage frm = new DoctorLogPage();
            formTransferHelper.TransferSizeAndLocation(this, frm);
            this.Hide();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK) { }
            this.Close();
        }
    }
}