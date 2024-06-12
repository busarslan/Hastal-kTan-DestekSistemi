using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Button;
using System.Data.OleDb;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;



namespace Hastalik_Tani_Destek_Sistemi
{
    public static class UserInfo
    {
        public static string TCNo { get; set; }
    }


    public partial class PatientLogPage : Form
    {
        public PatientLogPage()
        {
            IconHelper.SetAppIcon(this);
            Program.EnableDoubleBuffering(this);
            formTransferHelper = new OneFormToAnother();
            InitializeComponent();
            this.Load += new EventHandler(PatientLogPage_Load);
            CustomMenu.AddMenu(this);
            HakkindaButonu.AddAboutButton(this);
            GroupBox.AddGroupBox(this);        
        }
        #region Windows Form Designer generated code
        public void InitializeComponent()
        {
            BtnGirisPLP = new Button();
            BtnKayitOlPLP = new Button();
            TcLabelPLP = new Label();
            SifreLabelPLP = new Label();
            TxtTCPLP = new TextBox();
            TxtSfrePLP = new TextBox();
            BtnSifremiUnuttumPLP = new Button();
            BtnGeriPLP = new RoundedButton();
            SuspendLayout();

            // BtnGirisPLP 
            BtnGirisPLP.BackColor = Color.DodgerBlue;
            BtnGirisPLP.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGirisPLP.ForeColor = SystemColors.InactiveBorder;
            BtnGirisPLP.Location = new Point(292, 265);
            BtnGirisPLP.Margin = new Padding(2);
            BtnGirisPLP.Name = "BtnGirisPLP";
            BtnGirisPLP.Size = new Size(172, 48);
            BtnGirisPLP.TabIndex = 6;
            BtnGirisPLP.Text = "Giriş Yap";
            BtnGirisPLP.UseVisualStyleBackColor = false;
            BtnGirisPLP.Click += BtnGirisPLP_Click;

            // BtnKayitOlPLP 
            BtnKayitOlPLP.BackColor = Color.DodgerBlue;
            BtnKayitOlPLP.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnKayitOlPLP.ForeColor = SystemColors.InactiveBorder;
            BtnKayitOlPLP.Location = new Point(195, 338);
            BtnKayitOlPLP.Margin = new Padding(2);
            BtnKayitOlPLP.Name = "BtnKayitOlPLP";
            BtnKayitOlPLP.Size = new Size(163, 49);
            BtnKayitOlPLP.TabIndex = 7;
            BtnKayitOlPLP.Text = "Kayıt Ol";
            BtnKayitOlPLP.UseVisualStyleBackColor = false;
            BtnKayitOlPLP.Click += BtnKayitOlPLP_Click;

            // TcLabelPLP
            TcLabelPLP.AutoSize = true;
            TcLabelPLP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TcLabelPLP.ForeColor = Color.Black;
            TcLabelPLP.Location = new Point(234, 70);
            TcLabelPLP.Margin = new Padding(2, 0, 2, 0);
            TcLabelPLP.Name = "TcLabelPLP";
            TcLabelPLP.Size = new Size(136, 24);
            TcLabelPLP.TabIndex = 8;
            TcLabelPLP.Text = "T.C. Kimlik No";
            TcLabelPLP.Click += label1_Click;

            // SifreLabelPLP
            SifreLabelPLP.AutoSize = true;
            SifreLabelPLP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SifreLabelPLP.Location = new Point(234, 166);
            SifreLabelPLP.Margin = new Padding(2, 0, 2, 0);
            SifreLabelPLP.Name = "SifreLabelPLP";
            SifreLabelPLP.Size = new Size(50, 24);
            SifreLabelPLP.TabIndex = 9;
            SifreLabelPLP.Text = "Şifre";
            SifreLabelPLP.Click += label2_Click;

            // TxtTCPLP 
            TxtTCPLP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTCPLP.Location = new Point(234, 107);
            TxtTCPLP.Margin = new Padding(2);
            TxtTCPLP.Name = "TxtTCPLP";
            TxtTCPLP.Size = new Size(284, 32);
            TxtTCPLP.TabIndex = 10;
            TxtTCPLP.TextChanged += TxtTCPLP_TextChanged;

            // TxtSfrePLP 
            TxtSfrePLP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSfrePLP.Location = new Point(234, 206);
            TxtSfrePLP.Margin = new Padding(2);
            TxtSfrePLP.Name = "TxtSfrePLP";
            TxtSfrePLP.PasswordChar = '*';
            TxtSfrePLP.Size = new Size(284, 32);
            TxtSfrePLP.TabIndex = 11;
            TxtSfrePLP.TextChanged += TxtSfrePLP_TextChanged;

            // BtnSifremiUnuttumPLP 
            BtnSifremiUnuttumPLP.BackColor = Color.DodgerBlue;
            BtnSifremiUnuttumPLP.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSifremiUnuttumPLP.ForeColor = SystemColors.InactiveBorder;
            BtnSifremiUnuttumPLP.Location = new Point(418, 338);
            BtnSifremiUnuttumPLP.Margin = new Padding(2);
            BtnSifremiUnuttumPLP.Name = "BtnSifremiUnuttumPLP";
            BtnSifremiUnuttumPLP.Size = new Size(162, 49);
            BtnSifremiUnuttumPLP.TabIndex = 12;
            BtnSifremiUnuttumPLP.Text = "Şifremi Unuttum";
            BtnSifremiUnuttumPLP.UseVisualStyleBackColor = false;
            BtnSifremiUnuttumPLP.Click += BtnSifremiUnuttumPLP_Click;

            // BtnGeriPLP
            BtnGeriPLP.BackColor = Color.DodgerBlue;
            BtnGeriPLP.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGeriPLP.ForeColor = Color.White;
            BtnGeriPLP.Location = new Point(0, 537);
            BtnGeriPLP.Name = "BtnGeriPLP";
            BtnGeriPLP.Size = new Size(39, 38);
            BtnGeriPLP.TabIndex = 14;
            BtnGeriPLP.Text = " ← ";
            BtnGeriPLP.UseVisualStyleBackColor = false;
            BtnGeriPLP.Click += BtnGeriPLP_Click;

            // PatientLogPage
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            //ClientSize = new Size(800, 777);
            Controls.Add(BtnGeriPLP);
            Controls.Add(BtnSifremiUnuttumPLP);
            Controls.Add(TxtSfrePLP);
            Controls.Add(TxtTCPLP);
            Controls.Add(SifreLabelPLP);
            Controls.Add(TcLabelPLP);
            Controls.Add(BtnKayitOlPLP);
            Controls.Add(BtnGirisPLP);

            Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            Name = "PatientLogPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hastalık Tanı Destek Sistemi - Hasta Girişi";
            Load += PatientLogPage_Load_1;
            Resize += PatientLogPage_Resize;

            // Arka plan resmini ekleyin
            this.BackgroundImage = Hastalik_Tani_Destek_Sistemi.Properties.Resources.GeneralBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Button BtnGirisPLP;
        private Button BtnKayitOlPLP;
        private Label TcLabelPLP;
        private Label SifreLabelPLP;
        private TextBox TxtTCPLP;
        private TextBox TxtSfrePLP;
        private Button BtnSifremiUnuttumPLP;
        private RoundedButton BtnGeriPLP;
        private OneFormToAnother formTransferHelper;
        
        private void BtnGirisPLP_Click(object sender, EventArgs e)
        {
            string TCNo = TxtTCPLP.Text;
            string sifre = TxtSfrePLP.Text;

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\busbu\source\repos\Bgenone\HTDSnew\hastaneproje.accdb";

            string query = "SELECT COUNT(*) FROM hastalar WHERE TCNo = @TCNo AND sifre = @Sifre";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TCNo", TCNo);
                        command.Parameters.AddWithValue("@Sifre", sifre);

                        int userCount = (int)command.ExecuteScalar();

                        if (userCount > 0)
                        {

                            UserInfo.TCNo = TCNo;


                            alan_secim alanSecimFormu = new alan_secim();
                            formTransferHelper.TransferSizeAndLocation(this, alanSecimFormu);
                            this.Hide();
                            alanSecimFormu.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("TC No veya Şifre yanlış. Lütfen tekrar deneyin.");
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
        }
        private void BtnKayitOlPLP_Click(object sender, EventArgs e)
        {
            RegisterForm logpage = new RegisterForm();
            formTransferHelper.TransferSizeAndLocation(this, logpage);
            this.Hide();
            logpage.ShowDialog();
            if (logpage.DialogResult == DialogResult.OK) { }
            this.Close();
        }
        private void BtnSifremiUnuttumPLP_Click(object sender, EventArgs e)
        {
            ForgotPwd sfre = new ForgotPwd();
            formTransferHelper.TransferSizeAndLocation(this, sfre);
            this.Hide();
            sfre.ShowDialog();
            if (sfre.DialogResult == DialogResult.OK) { }
            this.Close();
        }
        public void PatientLogPage_Load(object sender, EventArgs e)
        {
            ResizeControls();
        }
        public void PatientLogPage_Resize(object sender, EventArgs e)
        {
            this.ClientSize = new Size(Math.Max(this.ClientSize.Width, 800), Math.Max(this.ClientSize.Height, 450));
            Versiyon.AddVersiyonLabel(this);
            ResizeControls();
        }
        private void ResizeControls()
        {

            float clientSizeWidthProp = this.ClientSize.Width / 800f;
            float clientSizeHeightProp = this.ClientSize.Height / 726f;

            int tcYPosition = 160;
            int sifreYPosition = 230;
            int girisYPosition = 330;

            ResizeLabel(TcLabelPLP, clientSizeWidthProp, clientSizeHeightProp, tcYPosition);
            ResizeTextBox(TxtTCPLP, clientSizeWidthProp, clientSizeHeightProp, tcYPosition + 20); 

            ResizeLabel(SifreLabelPLP, clientSizeWidthProp, clientSizeHeightProp, sifreYPosition);
            ResizeTextBox(TxtSfrePLP, clientSizeWidthProp, clientSizeHeightProp, sifreYPosition + 20); 

            ResizeRoundedButton(BtnGirisPLP, clientSizeWidthProp, clientSizeHeightProp, girisYPosition);

            ResizeRoundedButton(BtnKayitOlPLP, clientSizeWidthProp, clientSizeHeightProp, girisYPosition + BtnGirisPLP.Height + 60, -(BtnGirisPLP.Width / 2 + 10));
            ResizeRoundedButton(BtnSifremiUnuttumPLP, clientSizeWidthProp, clientSizeHeightProp, girisYPosition + BtnGirisPLP.Height + 60, BtnGirisPLP.Width / 2 + 10);
            ResizeButtonToBottomLeft(BtnGeriPLP, clientSizeWidthProp, clientSizeHeightProp);


            Versiyon.AddVersiyonLabel(this);

        }

        private void ResizeTextBox(TextBox textBox, float widthProp, float heightProp, int yOffset)
        {
            textBox.Size = new Size((int)(284 * widthProp), (int)(30 * heightProp));
            textBox.Location = new Point((this.ClientSize.Width - textBox.Width + 300) / 2, yOffset);
            AdjustFontSize(textBox);
        }

        private void ResizeLabel(Label label, float widthProp, float heightProp, int yOffset)
        {
            float labelWidth = 136 * widthProp;
            float labelHeight = 26 * heightProp;

            label.Size = new Size((int)labelWidth, (int)labelHeight);
            label.Location = new Point((int)(260 * widthProp - 150), yOffset + 13);

            // Label fontunu boyuta göre ayarla
            float fontSize = labelHeight / 1.6f;
            label.Font = new Font(label.Font.FontFamily, fontSize, FontStyle.Regular);
        }
        private void ResizeRoundedButton(Button button, float widthProp, float heightProp, int yOffset, int xOffset = 0)
        {
            button.Size = new Size((int)(200 * widthProp), (int)(36 * heightProp));
            button.Location = new Point(
                (this.ClientSize.Width - button.Width) / 2 + xOffset,
                yOffset);
            AdjustFontSize(button);
        }

        private void ResizeButtonToBottomLeft(RoundedButton button, float widthProp, float heightProp)
        {
            button.Size = new Size((int)(800*widthProp / 18), Math.Max((int)(726*heightProp / 13), 50));
            button.Location = new Point((int)(800*widthProp / 19), (int)(726*heightProp - Math.Max((int)(726*heightProp / 10), 70)));

            float fontSize = button.Width / 5.6f;
            button.Font = new Font(button.Font.FontFamily, fontSize, FontStyle.Regular); //Super method
        }

        private void AdjustFontSize(Control control)
        {
            float fontSize = control.Height / 2.5f;
            control.Font = new Font(control.Font.FontFamily, fontSize, FontStyle.Bold);
        }
        private void TxtTCPLP_TextChanged(object sender, EventArgs e) { }
        private void TxtSfrePLP_TextChanged(object sender, EventArgs e) { }
        private void BtnGeriPLP_Click(object sender, EventArgs e)
        {
            StartPage toSP = new StartPage();
            formTransferHelper.TransferSizeAndLocation(this, toSP);
            this.Hide();
            toSP.ShowDialog();
            if (toSP.DialogResult == DialogResult.OK) { }
            this.Close();
        }
        public void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void PatientLogPage_Load_1(object sender, EventArgs e) {  }
    }
}