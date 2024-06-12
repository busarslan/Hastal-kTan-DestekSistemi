using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Reflection.Emit.Label;
namespace Hastalik_Tani_Destek_Sistemi
{
    public partial class DoctorLogPage : Form 
    {
        public static class DoctorInfo
        {
            public static string TCNo { get; set; }
        }

        private Button BtnSifremiUnuttumDLP;
        private TextBox DTxtSfreDLP;
        private TextBox DTxtTCDLP;
        private Label SifreLabelDLP;
        private Label TcLabelDLP;
        private Button BtnGirisDLP;
        private RoundedButton BtnGeriDLP;
        private OleDbConnection conn;
        private OleDbCommand cmd;
        private OneFormToAnother formTransferHelper;

        public DoctorLogPage()
        {
            IconHelper.SetAppIcon(this);
            Program.EnableDoubleBuffering(this);
            InitializeComponent();
            this.Load += new EventHandler(DoctorLogPage_Load);
            CustomMenu.AddMenu(this);
            HakkindaButonu.AddAboutButton(this);
            formTransferHelper = new OneFormToAnother();

            GroupBox.AddGroupBox(this);
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\busbu\\source\\repos\\Bgenone\\HTDSnew\\hastaneproje.accdb";
            conn = new OleDbConnection(connectionString);
        }

        private void InitializeComponent()
        {
            this.Resize += new EventHandler(DoctorLogPage_Resize);
            this.Load += new EventHandler(DoctorLogPage_Load);

            BtnSifremiUnuttumDLP = new Button();
            BtnSifremiUnuttumDLP.BackColor = Color.DodgerBlue;
            BtnSifremiUnuttumDLP.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSifremiUnuttumDLP.ForeColor = SystemColors.InactiveBorder;
            BtnSifremiUnuttumDLP.Margin = new Padding(2);
            BtnSifremiUnuttumDLP.Name = "BtnSifremiUnuttumDLP";
            BtnSifremiUnuttumDLP.Text = "Şifremi Unuttum";
            BtnSifremiUnuttumDLP.UseVisualStyleBackColor = false;
            BtnSifremiUnuttumDLP.Click += BtnSifremiUnuttumDLP_Click;

            DTxtSfreDLP = new TextBox();
            DTxtSfreDLP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTxtSfreDLP.Margin = new Padding(2);
            DTxtSfreDLP.Name = "DTxtSfreDLP";
            DTxtSfreDLP.PasswordChar = '*';

            DTxtTCDLP = new TextBox();
            DTxtTCDLP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTxtTCDLP.Margin = new Padding(2);
            DTxtTCDLP.Name = "DTxtTCDLP";

            SifreLabelDLP = new Label();
            SifreLabelDLP.AutoSize = true;
            SifreLabelDLP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SifreLabelDLP.Margin = new Padding(2, 0, 2, 0);
            SifreLabelDLP.Name = "SifreLabelDLP";
            SifreLabelDLP.Text = "Şifre";

            TcLabelDLP = new Label();
            TcLabelDLP.AutoSize = true;
            TcLabelDLP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TcLabelDLP.ForeColor = Color.Black;
            TcLabelDLP.Margin = new Padding(2, 0, 2, 0);
            TcLabelDLP.Name = "TcLabelDLP";
            TcLabelDLP.Text = "T.C. Kimlik No";

            BtnGirisDLP = new Button();
            BtnGirisDLP.BackColor = Color.DodgerBlue;
            BtnGirisDLP.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGirisDLP.ForeColor = SystemColors.InactiveBorder;
            BtnGirisDLP.Margin = new Padding(2);
            BtnGirisDLP.Name = "BtnGirisDLP";
            BtnGirisDLP.Text = "Giriş Yap";
            BtnGirisDLP.UseVisualStyleBackColor = false;
            BtnGirisDLP.Click += BtnGirisDLP_Click;

            BtnGeriDLP = new RoundedButton();
            BtnGeriDLP.BackColor = Color.DodgerBlue;
            BtnGeriDLP.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGeriDLP.ForeColor = Color.White;
            BtnGeriDLP.Margin = new Padding(3, 4, 3, 4);
            BtnGeriDLP.Name = "BtnGeriDLP";
            BtnGeriDLP.Text = " ← ";
            BtnGeriDLP.UseVisualStyleBackColor = false;
            BtnGeriDLP.Click += BtnGeriDLP_Click;

            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            this.Controls.Add(BtnSifremiUnuttumDLP);
            this.Controls.Add(DTxtSfreDLP);
            this.Controls.Add(DTxtTCDLP);
            this.Controls.Add(SifreLabelDLP);
            this.Controls.Add(TcLabelDLP);
            this.Controls.Add(BtnGirisDLP);
            this.Controls.Add(BtnGeriDLP);
            Margin = new Padding(2);
            Name = "DoctorLogPage";
            Text = "Hastalık Tanı Destek Sistemi - Doktor Girişi";

            this.BackgroundImage = Hastalik_Tani_Destek_Sistemi.Properties.Resources.GeneralBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            ResumeLayout(false);
            PerformLayout();
        }


        private void DoctorLogPage_Load(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void DoctorLogPage_Resize(object sender, EventArgs e)
        {
            this.ClientSize = new Size(Math.Max(this.ClientSize.Width, 800), Math.Max(this.ClientSize.Height, 450));
            
            Versiyon.AddVersiyonLabel(this);
            ResizeControls();
        }

        private void ResizeControls()
        {
            float clientSizeWidthProp = (float)this.ClientSize.Width;
            float clientSizeHeightProp = (float)this.ClientSize.Height + (float)this.ClientSize.Height/7;

            ResizeLabel(TcLabelDLP, clientSizeWidthProp, clientSizeHeightProp, 4.5f);
            ResizeLabel(SifreLabelDLP, clientSizeWidthProp, clientSizeHeightProp, 3);

            ResizeTextBox(DTxtSfreDLP, clientSizeWidthProp, clientSizeHeightProp, SifreLabelDLP.Top);
            ResizeTextBox(DTxtTCDLP, clientSizeWidthProp, clientSizeHeightProp, TcLabelDLP.Top);

            ResizeRoundedButton(BtnGirisDLP, clientSizeWidthProp, clientSizeHeightProp, 2.5f,120);
            ResizeRoundedButton(BtnSifremiUnuttumDLP, clientSizeWidthProp, clientSizeHeightProp, 2.5f, BtnGirisDLP.Width + 120);

            ResizeButtonToBottomLeft(BtnGeriDLP, clientSizeWidthProp, clientSizeHeightProp - (float)this.ClientSize.Height / 7);
        }

        private void ResizeTextBox(TextBox textBox, float widthProp, float heightProp, float yaxis)
        {
            textBox.Size = new Size((int)(widthProp/5),(int)(heightProp/60));
            textBox.Location = new Point((this.ClientSize.Width - textBox.Width) / 2, (int)yaxis);
            float fontSize = heightProp / 60;
            textBox.Font = new Font(textBox.Font.FontFamily, fontSize, FontStyle.Regular);
        }

        private void ResizeLabel(Label label, float widthProp, float heightProp, float yaxis)
        {
            float labelWidth = widthProp/12;
            float labelHeight = heightProp/25;

            label.Size = new Size((int)labelWidth, (int)labelHeight);
            label.Location = new Point((int)(widthProp/5), (int)(heightProp / yaxis));

            float fontSize = Math.Min(labelHeight / 1.8f,24);
            label.Font = new Font(label.Font.FontFamily, fontSize, FontStyle.Regular);
        }

        private void ResizeRoundedButton(Button button, float widthProp, float heightProp, float yOffsetratio, int xOffset = 0)
        {
            button.Size = new Size((int)(widthProp/6), (int)(heightProp/14));
            button.Location = new Point((this.ClientSize.Width/2 - button.Width) + xOffset - 120, (int)(heightProp/yOffsetratio));

            float fontSize = button.Height / 4.8f;
            button.Font = new Font(button.Font.FontFamily, fontSize, FontStyle.Regular);
        }

        private void ResizeButtonToBottomLeft(RoundedButton button, float widthProp, float heightProp)
        {
            button.Size = new Size((int)(widthProp/18), Math.Max((int)(heightProp/13),50));
            button.Location = new Point((int)(widthProp/19), (int)(heightProp - Math.Max((int)(heightProp / 10), 70)));

            float fontSize = button.Width / 5.6f;
            button.Font = new Font(button.Font.FontFamily, fontSize, FontStyle.Regular);
        }

        private void AdjustFontSize(Control control)
        {
            float fontSize = control.Height / 2.5f;
            control.Font = new Font(control.Font.FontFamily, fontSize, FontStyle.Bold);
        }

        private void BtnGirisDLP_Click(object sender, EventArgs e)
        {
            string TCNo = DTxtTCDLP.Text;
            string sifre = DTxtSfreDLP.Text;

            if (TCNo.Length != 11 || !TCNo.All(char.IsDigit))
            {
                MessageBox.Show("Geçersiz TC No. TC No 11 haneli olmalıdır ve sadece rakam içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT COUNT(*) FROM doktorlar WHERE TCNo=@tcNo AND sifre=@sifre";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@tcNo", TCNo);
            cmd.Parameters.AddWithValue("@sifre", sifre);

            try
            {
                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    DoctorInfo.TCNo = TCNo;

                    DoctorMenu DoktorMenu= new DoctorMenu();
                    formTransferHelper.TransferSizeAndLocation(this, DoktorMenu);
                    this.Hide();
                    DoktorMenu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("TC No veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }           
        }

        private void BtnSifremiUnuttumDLP_Click(object sender, EventArgs e)
        {
            DoctorForgotPwd sfre = new DoctorForgotPwd();
            formTransferHelper.TransferSizeAndLocation(this, sfre);
            this.Hide();
            sfre.ShowDialog();
            this.Close();
        }
        private void BtnGeriDLP_Click(object sender, EventArgs e)
        {
            StartPage toSP = new StartPage();
            formTransferHelper.TransferSizeAndLocation(this, toSP);
            this.Hide();
            toSP.ShowDialog();
            this.Close();
        }
    }
}