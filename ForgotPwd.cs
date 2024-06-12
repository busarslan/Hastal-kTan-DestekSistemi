using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hastalik_Tani_Destek_Sistemi
{
    public partial class ForgotPwd : Form
    {
        public ForgotPwd()
        {
            IconHelper.SetAppIcon(this);
            Program.EnableDoubleBuffering(this);
            formTransferHelper = new OneFormToAnother();
            InitializeComponent();
            CustomMenu.AddMenu(this);
            HakkindaButonu.AddAboutButton(this);
            Versiyon.AddVersiyonLabel(this);
            GroupBox.AddGroupBox(this);
        }
        public void ForgotPwd_Load(object sender, EventArgs e)
        {
            ResizeControls();
        }
        public void ForgotPwd_Resize(object sender, EventArgs e)
        {
            this.ClientSize = new Size(Math.Max(this.ClientSize.Width, 800), Math.Max(this.ClientSize.Height, 450));
            ResizeControls();
        }

        #region Windows Form Designer generated code
        public void InitializeComponent()
        {
            this.Resize += new EventHandler(ForgotPwd_Resize);
            this.Load += new EventHandler(ForgotPwd_Load); 

            this.TxtSfreFP = new TextBox();
            this.TxtSfreFP2 = new TextBox();
            TxtTCFP = new TextBox();
            YeniSifreLabelFP = new Label();
            YeniSifreLabelFP2 = new Label();
            TcLabelFP = new Label();
            BtnGuncelleFP = new Button();
            BtnVazgecFP = new Button();
            SuspendLayout();

            // this.TxtSfreFP 
            this.TxtSfreFP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxtSfreFP.Location = new Point(203, 229);
            this.TxtSfreFP.Margin = new Padding(3, 4, 3, 4);
            this.TxtSfreFP.Name = "TxtSfreFP";
            this.TxtSfreFP.Size = new Size(377, 32);
            this.TxtSfreFP.TabIndex = 19;

            // this.TxtSfreFP2 
            this.TxtSfreFP2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxtSfreFP2.Location = new Point(203, 344);
            this.TxtSfreFP2.Margin = new Padding(3, 4, 3, 4);
            this.TxtSfreFP2.Name = "TxtSfreFP2";
            this.TxtSfreFP2.Size = new Size(377, 32);
            this.TxtSfreFP2.TabIndex = 20;

            // TxtTCFP 
            TxtTCFP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTCFP.Location = new Point(203, 125);
            TxtTCFP.Margin = new Padding(3, 4, 3, 4);
            TxtTCFP.Name = "TxtTCFP";
            TxtTCFP.Size = new Size(377, 32);
            TxtTCFP.TabIndex = 18;

            // YeniSifreLabelFP 
            YeniSifreLabelFP.AutoSize = true;
            YeniSifreLabelFP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YeniSifreLabelFP.Location = new Point(196, 189);
            YeniSifreLabelFP.Name = "YeniSifreLabelFP";
            YeniSifreLabelFP.Size = new Size(95, 24);
            YeniSifreLabelFP.TabIndex = 17;
            YeniSifreLabelFP.Text = "Yeni Şifre      ";

            // YeniSifreLabelFP2 
            YeniSifreLabelFP2.AutoSize = true;
            YeniSifreLabelFP2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YeniSifreLabelFP2.Location = new Point(196, 304);
            YeniSifreLabelFP2.Name = "YeniSifreLabelFP2";
            YeniSifreLabelFP2.Size = new Size(230, 24);
            YeniSifreLabelFP2.TabIndex = 18;
            YeniSifreLabelFP2.Text = "Şifre Tekrar   ";

            // TcLabelFP
            TcLabelFP.AutoSize = true;
            TcLabelFP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TcLabelFP.ForeColor = Color.Black;
            TcLabelFP.Location = new Point(196, 85);
            TcLabelFP.Name = "TcLabelFP";
            TcLabelFP.Size = new Size(136, 24);
            TcLabelFP.TabIndex = 16;
            TcLabelFP.Text = "T.C. Kimlik No";

            // BtnGuncelleFP
            BtnGuncelleFP.BackColor = Color.DodgerBlue;
            BtnGuncelleFP.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuncelleFP.ForeColor = SystemColors.InactiveBorder;
            BtnGuncelleFP.Location = new Point(0, 0);
            BtnGuncelleFP.Margin = new Padding(3, 4, 3, 4);
            BtnGuncelleFP.Name = "BtnGuncelleFP";
            BtnGuncelleFP.Size = new Size(379, 73);
            BtnGuncelleFP.TabIndex = 15;
            BtnGuncelleFP.Text = "Güncelle";
            BtnGuncelleFP.UseVisualStyleBackColor = false;
            BtnGuncelleFP.Click += BtnGuncelleFP_Click;

            // BtnVazgecFP 
            BtnVazgecFP.BackColor = Color.DodgerBlue;
            BtnVazgecFP.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVazgecFP.ForeColor = SystemColors.InactiveBorder;
            BtnVazgecFP.Location = new Point(0, 0);
            BtnVazgecFP.Margin = new Padding(3, 4, 3, 4);
            BtnVazgecFP.Name = "BtnVazgecFP";
            BtnVazgecFP.Size = new Size(181, 73);
            BtnVazgecFP.TabIndex = 20;
            BtnVazgecFP.Text = "Vazgeç";
            BtnVazgecFP.UseVisualStyleBackColor = false;
            BtnVazgecFP.Click += BtnVazgecFP_Click;

            // ForgotPwd 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 854);
            Controls.Add(BtnVazgecFP);
            Controls.Add(this.TxtSfreFP);
            Controls.Add(this.TxtSfreFP2);
            Controls.Add(TxtTCFP);
            Controls.Add(YeniSifreLabelFP);
            Controls.Add(YeniSifreLabelFP2);
            Controls.Add(TcLabelFP);
            Controls.Add(BtnGuncelleFP);
            Margin = new Padding(2);
            Name = "ForgotPwd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifremi Unuttum";
            Load += ForgotPwd_Load_1;
            Resize += ForgotPwd_Resize;

            // Arka plan resmini ekleyin
            this.BackgroundImage = Hastalik_Tani_Destek_Sistemi.Properties.Resources.GeneralBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        public TextBox TxtSfreFP;
        public TextBox TxtSfreFP2;
        public TextBox TxtTCFP;
        public Label YeniSifreLabelFP;
        public Label YeniSifreLabelFP2;
        public Label TcLabelFP;
        public Button BtnGuncelleFP;
        public Button BtnVazgecFP;
        private OneFormToAnother formTransferHelper;
        public ObjectFontAdjustment objectFontAdjustment;

        private void ResizeControls()
        {            
                float clientSizeWidthProp = this.ClientSize.Width;
                float clientSizeHeightProp = this.ClientSize.Height;
                ResizeButton(BtnGuncelleFP, clientSizeWidthProp, clientSizeHeightProp, 2.1f);
                ResizeButton(BtnVazgecFP, clientSizeWidthProp, clientSizeHeightProp, 1.75f);

                ResizeLabel_TextBox(TcLabelFP, clientSizeWidthProp, clientSizeHeightProp, 7.5f, 0, TxtTCFP);
                ResizeLabel_TextBox(YeniSifreLabelFP, clientSizeWidthProp, clientSizeHeightProp, 6.25f, TcLabelFP.Height, TxtSfreFP);
                ResizeLabel_TextBox(YeniSifreLabelFP2, clientSizeWidthProp, clientSizeHeightProp, 5f, YeniSifreLabelFP.Height + TcLabelFP.Height, TxtSfreFP2);
                ResizeLabel_TextBox(YeniSifreLabelFP2, clientSizeWidthProp, clientSizeHeightProp, 5f, TcLabelFP.Height * 1.8f, TxtSfreFP2);

                ResizeTextBox(TxtTCFP, clientSizeWidthProp, clientSizeHeightProp, TcLabelFP);
                ResizeTextBox(TxtSfreFP, clientSizeWidthProp, clientSizeHeightProp, YeniSifreLabelFP);
                ResizeTextBox(TxtSfreFP2, clientSizeWidthProp, clientSizeHeightProp, YeniSifreLabelFP2);
            Versiyon.AddVersiyonLabel(this);
        }
            private void ResizeButton(Button button, float widthProp, float heightProp, float yaxis)
            {
                button.Size = new Size((int)(widthProp / 5), (int)(heightProp / 13.8));
                button.Location = new Point((this.ClientSize.Width - button.Width) / 2, (int)(65 + (heightProp / yaxis)));
            }
            private void ResizeLabel_TextBox(Label label, float widthProp, float heightProp, float yaxis, float abc, TextBox textbox1)
            {
                float labelWidth = widthProp / 10;
                float labelHeight = heightProp / 20;
                label.Size = new Size((int)labelWidth, (int)labelHeight);
                label.Location = new Point((int)(widthProp / 2 - label.Width / 2 - textbox1.Width), (int)(65 + abc + (heightProp / yaxis)));
                //Adjust label font size according to the height
                float fontSize = labelHeight / 1.8f;
                label.Font = new Font(label.Font.FontFamily, fontSize, FontStyle.Regular);
            }
            private void ResizeTextBox(TextBox textBox1, float widthProp, float heightProp, Label CurrentLabel)
            {
                textBox1.Size = new Size((int)(widthProp / 3.5f), (int)(heightProp / 4f));
                textBox1.Left = ((int)((widthProp - textBox1.Width) / 2));
                textBox1.Top = CurrentLabel.Top + 3;
                textBox1.Top = (int)(CurrentLabel.Top);
            }
            public void BtnGuncelleFP_Click(object sender, EventArgs e)
            {
                string tcNo = TxtTCFP.Text;
                string yeniSifre = TxtSfreFP.Text;
                string yeniSifreTekrar = TxtSfreFP2.Text;

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

                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\busbu\source\repos\Bgenone\HTDSnew\hastaneproje.accdb";

                string queryCheckUser = "SELECT COUNT(*) FROM hastalar WHERE TCNo = ?";

                string queryUpdatePassword = "UPDATE hastalar SET sifre = ? WHERE TCNo = ?";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OleDbCommand commandCheckUser = new OleDbCommand(queryCheckUser, connection))
                    {
                        commandCheckUser.Parameters.Add("TCNo", OleDbType.VarChar).Value = tcNo;

                        object result = commandCheckUser.ExecuteScalar();
                        int userCount = result != null ? Convert.ToInt32(result) : 0;

                        if (userCount > 0)
                        {
                            using (OleDbCommand commandUpdatePassword = new OleDbCommand(queryUpdatePassword, connection))
                            {
                                commandUpdatePassword.Parameters.Add("sifre", OleDbType.VarChar).Value = yeniSifre;
                                commandUpdatePassword.Parameters.Add("TCNo", OleDbType.VarChar).Value = tcNo;

                                commandUpdatePassword.ExecuteNonQuery();

                                MessageBox.Show("Şifreniz başarıyla güncellendi.");
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
        public void BtnVazgecFP_Click(object sender, EventArgs e)
        {
            PatientLogPage hst = new PatientLogPage();
            formTransferHelper.TransferSizeAndLocation(this, hst);
            this.Hide();
            hst.ShowDialog();
            if (hst.DialogResult == DialogResult.OK) { }
            this.Close();
        }
        private void ForgotPwd_Load_1(object sender, EventArgs e) { }
    }
}