using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Hastalik_Tani_Destek_Sistemi
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            IconHelper.SetAppIcon(this);
            formTransferHelper = new OneFormToAnother();
            InitializeComponent();
            CustomMenu.AddMenu(this);
            CustomMenu.AddMenu(this.panel1);
            HakkindaButonu.AddAboutButton(this);
            HakkindaButonu.AddAboutButton(this.panel1);
            GroupBox.AddGroupBox(this);
            GroupBox.AddGroupBox(this.panel1);
            Program.EnableDoubleBuffering(this);
            Program.EnableDoubleBuffering(this.panel1);
        }

        #region Windows Form Designer generated code
        public void InitializeComponent()
        {
            this.Resize += new EventHandler(RegisterForm_Resize);
            this.Load += new EventHandler(RegisterForm_Load);

            this.panel1 = new Panel();
            this.panel1.BackgroundImage = Hastalik_Tani_Destek_Sistemi.Properties.Resources.GeneralBackground;
            this.panel1.BackgroundImageLayout = ImageLayout.Stretch;
            this.TxtSydRF = new TextBox();
            this.TxtAdRF = new TextBox();
            this.label2RF = new Label();
            this.label1RF = new Label();
            this.BtnKaydiTamamlaRF = new Button();
            this.TxtYasRF = new TextBox();
            this.TxtTcRF = new TextBox();
            this.label3RF = new Label();
            this.label4RF = new Label();
            this.label6RF = new Label();
            this.TxtMail = new TextBox();
            this.label7RF = new Label();
            this.label8RF = new Label();
            this.TxtSfreRF = new TextBox();
            this.label9RF = new Label();
            this.TxtSfreRF2 = new TextBox();
            this.label10RF = new Label();
            this.MskTxtTelefon = new MaskedTextBox();
            this.CmbBxCnsyt = new ComboBox();
            this.BtnGeriRF = new RoundedButton();
            SuspendLayout();

            this.panel1.AutoScroll = true;
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.HorizontalScroll.Visible = true;

            // TxtSydRF 
            this.TxtSydRF.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxtSydRF.Location = new Point(220, 157);
            this.TxtSydRF.Margin = new Padding(3, 2, 3, 2);
            this.TxtSydRF.Name = "TxtSydRF";
            this.TxtSydRF.Size = new Size(377, 32);
            this.TxtSydRF.TabIndex = 18;
            this.TxtSydRF.TextChanged += TxtSifre_TextChanged;

            // TxtAdRF 
            this.TxtAdRF.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxtAdRF.Location = new Point(220, 86);
            this.TxtAdRF.Margin = new Padding(3, 2, 3, 2);
            this.TxtAdRF.Name = "TxtAdRF";
            this.TxtAdRF.Size = new Size(377, 32);
            this.TxtAdRF.TabIndex = 17;

            // label2RF 
            this.label2RF.AutoSize = true;
            this.label2RF.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2RF.Location = new Point(216, 130);
            this.label2RF.Name = "label2RF";
            this.label2RF.Size = new Size(78, 24);
            this.label2RF.TabIndex = 16;
            this.label2RF.Text = "Soyisim         ";

            // label1RF 
            this.label1RF.AutoSize = true;
            this.label1RF.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1RF.ForeColor = Color.Black;
            this.label1RF.Location = new Point(216, 59);
            this.label1RF.Name = "label1RF";
            this.label1RF.Size = new Size(48, 24);
            this.label1RF.TabIndex = 15;
            this.label1RF.Text = "İsim              ";
            this.label1RF.Click += label1RF_Click;

            // BtnKaydiTamamlaRF 
            this.BtnKaydiTamamlaRF.BackColor = Color.DodgerBlue;
            this.BtnKaydiTamamlaRF.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.BtnKaydiTamamlaRF.ForeColor = SystemColors.InactiveBorder;
            //BtnKaydiTamamlaRF.Location = new Point(629, 663);
            this.BtnKaydiTamamlaRF.Margin = new Padding(3, 2, 3, 2);
            this.BtnKaydiTamamlaRF.Name = "BtnKaydiTamamlaRF";
            this.BtnKaydiTamamlaRF.Size = new Size(159, 62);
            this.BtnKaydiTamamlaRF.TabIndex = 20;
            this.BtnKaydiTamamlaRF.Text = "Kaydı Tamamla";
            this.BtnKaydiTamamlaRF.UseVisualStyleBackColor = false;
            this.BtnKaydiTamamlaRF.Click += BtnKaydiTamamlaRF_Click;

            // TxtYasRF 
            this.TxtYasRF.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxtYasRF.Location = new Point(220, 304);
            this.TxtYasRF.Margin = new Padding(3, 2, 3, 2);
            this.TxtYasRF.Name = "TxtYasRF";
            this.TxtYasRF.Size = new Size(377, 32);
            this.TxtYasRF.TabIndex = 24;

            // TxtTcRF 
            this.TxtTcRF.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxtTcRF.Location = new Point(220, 228);
            this.TxtTcRF.Margin = new Padding(3, 2, 3, 2);
            this.TxtTcRF.Name = "TxtTcRF";
            this.TxtTcRF.Size = new Size(377, 32);
            this.TxtTcRF.TabIndex = 23;

            // label3RF 
            this.label3RF.AutoSize = true;
            this.label3RF.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3RF.Location = new Point(216, 272);
            this.label3RF.Name = "label3RF";
            this.label3RF.Size = new Size(42, 24);
            this.label3RF.TabIndex = 22;
            this.label3RF.Text = "Yaş               ";

            // label4RF 
            this.label4RF.AutoSize = true;
            this.label4RF.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4RF.ForeColor = Color.Black;
            this.label4RF.Location = new Point(216, 201);
            this.label4RF.Name = "label4RF";
            this.label4RF.Size = new Size(136, 24);
            this.label4RF.TabIndex = 21;
            this.label4RF.Text = "T.C. Kimlik No";
            this.label4RF.Click += label4RF_Click;

            // label6RF 
            this.label6RF.AutoSize = true;
            this.label6RF.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6RF.ForeColor = Color.Black;
            this.label6RF.Location = new Point(216, 343);
            this.label6RF.Name = "label6RF";
            this.label6RF.Size = new Size(80, 24);
            this.label6RF.TabIndex = 25;
            this.label6RF.Text = "Cinsiyet      ";

            // TxtMail 
            this.TxtMail.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxtMail.Location = new Point(220, 512);
            this.TxtMail.Margin = new Padding(3, 2, 3, 2);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new Size(377, 32);
            this.TxtMail.TabIndex = 32;
            this.TxtMail.TextChanged += TxtMail_TextChanged;

            // label7RF 
            this.label7RF.AutoSize = true;
            this.label7RF.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7RF.Location = new Point(216, 486);
            this.label7RF.Name = "label7RF";
            this.label7RF.Size = new Size(46, 24);
            this.label7RF.TabIndex = 30;
            this.label7RF.Text = "Mail              ";

            // label8RF 
            this.label8RF.AutoSize = true;
            this.label8RF.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8RF.ForeColor = Color.Black;
            this.label8RF.Location = new Point(220, 414);
            this.label8RF.Name = "label8RF";
            this.label8RF.Size = new Size(77, 24);
            this.label8RF.TabIndex = 29;
            this.label8RF.Text = "Telefon  ";

            // TxtSfreRF
            this.TxtSfreRF.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxtSfreRF.Location = new Point(220, 583);
            this.TxtSfreRF.Margin = new Padding(3, 2, 3, 2);
            this.TxtSfreRF.Name = "TxtSfreRF";
            this.TxtSfreRF.Size = new Size(377, 32);
            this.TxtSfreRF.TabIndex = 34;
            this.TxtSfreRF.TextChanged += textBox7_TextChanged;

            // label9RF 
            this.label9RF.AutoSize = true;
            this.label9RF.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9RF.Location = new Point(216, 556);
            this.label9RF.Name = "label9RF";
            this.label9RF.Size = new Size(50, 24);
            this.label9RF.TabIndex = 33;
            this.label9RF.Text = "Şifre             ";
            this.label9RF.Click += label9RF_Click;

            // TxtSfreRF2
            this.TxtSfreRF2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxtSfreRF2.Location = new Point(220, 654);
            this.TxtSfreRF2.Margin = new Padding(3, 2, 3, 2);
            this.TxtSfreRF2.Name = "TxtSfreRF2";
            this.TxtSfreRF2.Size = new Size(377, 32);
            this.TxtSfreRF2.TabIndex = 35;
            this.TxtSfreRF2.TextChanged += textBox8_TextChanged;

            // label1RF0
            this.label10RF.AutoSize = true;
            this.label10RF.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label10RF.Location = new Point(216, 627);
            this.label10RF.Name = "label10RF";
            this.label10RF.Size = new Size(185, 24);
            this.label10RF.TabIndex = 36;
            this.label10RF.Text = "Şifre Tekrar  ";
            this.label10RF.Click += label10RF_Click;

            // MskTxtTelefon 
            this.MskTxtTelefon.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.MskTxtTelefon.Location = new Point(216, 441);
            this.MskTxtTelefon.Margin = new Padding(3, 2, 3, 2);
            this.MskTxtTelefon.Mask = "\\+\\9\\0 (999) 000-0000";
            this.MskTxtTelefon.Name = "MskTxtTelefon";
            this.MskTxtTelefon.Size = new Size(377, 32);
            this.MskTxtTelefon.TabIndex = 38;

            // CmbBxCnsyt 
            this.CmbBxCnsyt.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CmbBxCnsyt.FormattingEnabled = true;
            this.CmbBxCnsyt.Items.AddRange(new object[] { "Kadın", "Erkek" });
            this.CmbBxCnsyt.Location = new Point(220, 370);
            this.CmbBxCnsyt.Margin = new Padding(3, 2, 3, 2);
            this.CmbBxCnsyt.Name = "CmbBxCnsyt";
            this.CmbBxCnsyt.Size = new Size(377, 32);
            this.CmbBxCnsyt.TabIndex = 80;
            this.CmbBxCnsyt.DropDownStyle = ComboBoxStyle.DropDownList;

            // BtnKaydiTamamlaRF location
            this.BtnKaydiTamamlaRF.Location = new Point(this.ClientSize.Width - BtnKaydiTamamlaRF.Width - 20, this.ClientSize.Height - BtnKaydiTamamlaRF.Height - 20);

            // BtnGeriRF 
            this.BtnGeriRF.BackColor = Color.DodgerBlue;
            this.BtnGeriRF.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.BtnGeriRF.ForeColor = Color.White;
            //BtnGeriRF.Location = new Point(0, 676);
            this.BtnGeriRF.Name = "BtnGeriRF";
            this.BtnGeriRF.Size = new Size(39, 38);
            this.BtnGeriRF.TabIndex = 81;
            this.BtnGeriRF.Text = " ← ";
            this.BtnGeriRF.UseVisualStyleBackColor = false;
            this.BtnGeriRF.Click += BtnGeriRF_Click;

            // RegisterForm
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 726);
            this.Controls.Add(this.BtnGeriRF);
            this.Controls.Add(this.CmbBxCnsyt);
            this.Controls.Add(this.MskTxtTelefon);
            this.Controls.Add(this.TxtSfreRF);
            this.Controls.Add(this.TxtSfreRF2);
            this.Controls.Add(this.label9RF);
            this.Controls.Add(this.label10RF);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label7RF);
            this.Controls.Add(this.label8RF);
            this.Controls.Add(this.label6RF);
            this.Controls.Add(this.TxtYasRF);
            this.Controls.Add(this.TxtTcRF);
            this.Controls.Add(this.label3RF);
            this.Controls.Add(this.label4RF);
            this.Controls.Add(this.BtnKaydiTamamlaRF);
            this.Controls.Add(this.TxtSydRF);
            this.Controls.Add(this.TxtAdRF);
            this.Controls.Add(this.label2RF);
            this.Controls.Add(this.label1RF);
            this.Controls.Add(this.panel1);
            Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hastalık Tanı Destek Sistemi - Hasta Kayıt";

            this.BackgroundImage = Hastalik_Tani_Destek_Sistemi.Properties.Resources.GeneralBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        public TextBox TxtSydRF;
        public TextBox TxtAdRF;
        public Label label2RF;
        public Label label1RF;
        public Button BtnKaydiTamamlaRF;
        public TextBox TxtYasRF;
        public TextBox TxtTcRF;
        public Label label3RF;
        public Label label4RF;
        public Label label6RF;
        public TextBox TxtMail;
        public Label label7RF;
        public Label label8RF;
        public TextBox TxtSfreRF;
        public TextBox TxtSfreRF2;
        public Label label9RF;
        public Label label10RF;
        public MaskedTextBox MskTxtTelefon;
        public ComboBox CmbBxCnsyt;
        public RoundedButton BtnGeriRF;
        private OneFormToAnother formTransferHelper;
        public Panel panel1;
        public void RegisterForm_Load(object sender, EventArgs e)
        {
            ResizeControls();
        }
        public void RegisterForm_Resize(object sender, EventArgs e)
        {
            this.ClientSize = new Size(Math.Max(this.ClientSize.Width, 800), Math.Max(this.ClientSize.Height, 450));
            ResizeControls();
        }
        private void ResizeControls()
        {
            float clientSizeWidthProp = this.ClientSize.Width / 800f;
            float clientSizeHeightProp = this.ClientSize.Height / 726f;

            int ySpacing = 200;
            int bottomOfTxtSfreRF2 = TxtSfreRF2.Bottom;
            ResizeButtonToBottomRight(BtnKaydiTamamlaRF, clientSizeWidthProp, clientSizeHeightProp, bottomOfTxtSfreRF2 + ySpacing);
            ResizeButtonToBottomLeft(BtnGeriRF, clientSizeWidthProp, clientSizeHeightProp, bottomOfTxtSfreRF2 + ySpacing);

            int labelWidth = 100; // Etiketlerin genişliği

            ResizeLabelAndTextBox(label1RF, TxtAdRF, TxtAdRF, clientSizeWidthProp, clientSizeHeightProp, 60, labelWidth, 1);
            ResizeLabelAndTextBox(label2RF, TxtSydRF, TxtAdRF, clientSizeWidthProp, clientSizeHeightProp, 140, labelWidth, 0);
            ResizeLabelAndTextBox(label4RF, TxtTcRF, TxtSydRF, clientSizeWidthProp, clientSizeHeightProp, 230, labelWidth, 0);
            ResizeLabelAndTextBox(label3RF, TxtYasRF, TxtTcRF, clientSizeWidthProp, clientSizeHeightProp, 320, labelWidth, 0);
            ResizeLabelAndComboBox(label6RF, CmbBxCnsyt, TxtTcRF, clientSizeWidthProp, clientSizeHeightProp, 410, labelWidth, 0);
            ResizeLabelAndMaskedTextBox(label8RF, MskTxtTelefon, TxtTcRF, clientSizeWidthProp, clientSizeHeightProp, 500, labelWidth, 0);
            ResizeLabelAndTextBox(label7RF, TxtMail, TxtYasRF, clientSizeWidthProp, clientSizeHeightProp, 590, labelWidth, 0);
            ResizeLabelAndTextBox(label9RF, TxtSfreRF, TxtMail, clientSizeWidthProp, clientSizeHeightProp, 680, labelWidth, 0);
            ResizeLabelAndTextBox(label10RF, TxtSfreRF2, TxtSfreRF, clientSizeWidthProp, clientSizeHeightProp, 770, labelWidth, 0);

            Versiyon.AddVersiyonLabel(this);
        }

        private void ResizeButtonToBottomRight(Button button, float widthProp, float heightProp, int y)
        {
            button.Size = new Size((int)(235 * widthProp), (int)(40 * heightProp));
            button.Location = new Point(this.ClientSize.Width - button.Width - (int)(10 * widthProp), y - button.Height - (int)(10 * heightProp));
            AdjustFontSize(button);
            this.panel1.Controls.Add(button);
        }

        private void ResizeButtonToBottomLeft(RoundedButton button, float widthProp, float heightProp, float abc)
        {
            button.Size = new Size((int)(800 * widthProp / 18), Math.Max((int)(726 * heightProp / 13), 50));
            button.Location = new Point((int)(800 * widthProp / 19), BtnKaydiTamamlaRF.Top + (int)0.5*  BtnKaydiTamamlaRF.Height); 

            float fontSize = button.Width / 5.6f;
            button.Font = new Font(button.Font.FontFamily, fontSize, FontStyle.Regular);

            this.panel1.Controls.Add(button);
        }

        private void ResizeRoundedButton(Button button, float widthProp, float heightProp, int yOffset, int ySpacing, int xOffset = 0)
        {
            button.Size = new Size((int)(200 * widthProp), (int)(36 * heightProp));
            button.Location = new Point(
                (this.ClientSize.Width - button.Width) / 2 + xOffset,
                (this.ClientSize.Height / 2) + yOffset - ySpacing);

            AdjustFontSize(button);
            this.panel1.Controls.Add(button);
        }
        private void ResizeLabelAndTextBox(Label label, TextBox textBox, TextBox textBox2,float widthProp, float heightProp, int yOffset, int labelWidth, int change)
        {
            float labelHeight = 20 * heightProp;
            label.Size = new Size((int)(labelWidth * widthProp), (int)labelHeight);
            label.Location = new Point((int)(this.ClientSize.Width / 4), (this.ClientSize.Height / 20) + yOffset);

            textBox.Size = new Size((int)(284 * widthProp), (int)(30 * heightProp));
            if(change != 0 ) { textBox.Location = new Point(label.Location.X + label.Width + 160, label.Location.Y); }
            else { textBox.Location = new Point(textBox2.Left, label.Location.Y); }

            float fontSize = labelHeight / 1.6f;
            label.Font = new Font(label.Font.FontFamily, fontSize, FontStyle.Regular);
            AdjustFontSize(textBox);

            this.panel1.Controls.Add(label);
            this.panel1.Controls.Add(textBox);
        }
        private void ResizeLabelAndMaskedTextBox(Label label, MaskedTextBox maskedTextBox, TextBox textBox, float widthProp, float heightProp, int yOffset, int labelWidth, int change)
        {
            float labelHeight = 20 * heightProp;
            label.Size = new Size((int)(labelWidth * widthProp), (int)labelHeight);
            label.Location = new Point((int)(this.ClientSize.Width / 4), (this.ClientSize.Height / 20) + yOffset);

            maskedTextBox.Size = new Size((int)(284 * widthProp), (int)(30 * heightProp));
            if (change != 0) { maskedTextBox.Location = new Point(label.Location.X + label.Width + 160, label.Location.Y); }
            else { maskedTextBox.Location = new Point(textBox.Left, label.Location.Y); }

            float fontSize = labelHeight / 1.6f;
            label.Font = new Font(label.Font.FontFamily, fontSize, FontStyle.Regular);
            AdjustFontSize(maskedTextBox);

            this.panel1.Controls.Add(label);
            this.panel1.Controls.Add(maskedTextBox);
        }
        private void ResizeLabelAndComboBox(Label label, ComboBox comboBox, TextBox textBox, float widthProp, float heightProp, int yOffset, int labelWidth, int change)
        {
            float labelHeight = 20 * heightProp;
            label.Size = new Size((int)(labelWidth * widthProp), (int)labelHeight);
            label.Location = new Point((int)(this.ClientSize.Width / 4), (this.ClientSize.Height / 20) + yOffset);

            comboBox.Size = new Size((int)(284 * widthProp), (int)(30 * heightProp));
            if (change != 0) { comboBox.Location = new Point(label.Location.X + label.Width + 170, label.Location.Y); }
            else { comboBox.Location = new Point(textBox.Left, label.Location.Y); }

            float fontSize = labelHeight / 1.6f;
            label.Font = new Font(label.Font.FontFamily, fontSize, FontStyle.Regular);
            AdjustFontSize(comboBox);

            this.panel1.Controls.Add(label);
            this.panel1.Controls.Add(comboBox);
        }
        private void ResizeRoundedButton(Button button, float widthProp, float heightProp, int yOffset, int xOffset = 0)
        {
            button.Size = new Size((int)(200 * widthProp), (int)(36 * heightProp));
            button.Location = new Point(
                (this.ClientSize.Width - button.Width) / 2 + xOffset,
                (this.ClientSize.Height / 2) + yOffset);

            AdjustFontSize(button);
            this.panel1.Controls.Add(button);
        }
        private void AdjustFontSize(Control control)
        {
            float fontSize = control.Height / 2.5f;
            control.Font = new Font(control.Font.FontFamily, fontSize, FontStyle.Bold);
            this.panel1.Controls.Add(control);
        }
        public void label1RF_Click(object sender, EventArgs e) { }
        public void TxtSifre_TextChanged(object sender, EventArgs e) { }
        public void TxtSifre2_TextChanged(object sender, EventArgs e) { }
        public void textBox8_TextChanged(object sender, EventArgs e) { }
        public void label10RF_Click(object sender, EventArgs e) { }
        public void label4RF_Click(object sender, EventArgs e) { }
        public void label9RF_Click(object sender, EventArgs e) { }
        public void textBox7_TextChanged(object sender, EventArgs e) { }
        public void BtnKaydiTamamlaRF_Click(object sender, EventArgs e)
        {
            string ad = TxtAdRF.Text;
            string soyad = TxtSydRF.Text;
            string tc = TxtTcRF.Text;
            string yas = TxtYasRF.Text;
            string cinsiyet = CmbBxCnsyt.Text;
            string telefon = MskTxtTelefon.Text;
            string mail = TxtMail.Text;
            string sifre = TxtSfreRF.Text;
            string sifreTekrar = TxtSfreRF2.Text;

            string[] requiredFields = { ad, soyad, tc, yas, cinsiyet, telefon, mail, sifre, sifreTekrar };

            foreach (string field in requiredFields)
            {
                if (string.IsNullOrEmpty(field))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }
            }

            string tcKimlikNo = tc.Trim();

            if (tcKimlikNo.Length != 11 || !IsAllDigits(tcKimlikNo))
            {
                MessageBox.Show("Lütfen sadece rakamdan oluşan 11 haneli bir kimlik numarası girin.", "Hatalı T.C no");
                return;
            }
            else
            {
                MessageBox.Show("TC Kimlik Numarası geçerli.");
            }

            if (!IsValidEmail(mail))
            {
                MessageBox.Show("Geçersiz bir e-posta adresi girdiniz.", "Hatalı E-posta");
                return;
            }
            else
            {
                MessageBox.Show("Geçerli bir e-posta adresi girdiniz.", "E-posta Doğrulama");
            }

            if (sifre != sifreTekrar)
            {
                MessageBox.Show("Şifreler eşleşmiyor, lütfen tekrar deneyin.");
                return;
            }

            if (!IsValidSifre(sifre))
            {
                MessageBox.Show("Şifre en az 8 karakter uzunluğunda olmalı, en az bir büyük harf, bir sayı ve bir özel karakter içermelidir.", "Hatalı şifre");
                return;
            }
            else
            {
                MessageBox.Show("Geçerli bir şifre girdiniz.");
            }


            MessageBox.Show("Kaydınız başarıyla yapıldı. Şifreniz: " + sifre);

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\busbu\source\repos\Bgenone\HTDSnew\hastaneproje.accdb";

            string queryCheckTC = "SELECT COUNT(*) FROM hastalar WHERE TCNo = ?";
            string queryInsert = "INSERT INTO hastalar (isim, soyisim, TCNo, yaş, cinsiyet, telefon, mail, sifre) " +
                                  "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OleDbCommand checkCmd = new OleDbCommand(queryCheckTC, connection))
                    {
                        checkCmd.Parameters.AddWithValue("?", tc);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Bu TC numarası ile kayıtlı bir hasta zaten mevcut.");
                            return;
                        }
                    }

                    using (OleDbCommand insertCmd = new OleDbCommand(queryInsert, connection))
                    {
                        insertCmd.Parameters.AddWithValue("?", ad);
                        insertCmd.Parameters.AddWithValue("?", soyad);
                        insertCmd.Parameters.AddWithValue("?", tc);
                        insertCmd.Parameters.AddWithValue("?", yas);
                        insertCmd.Parameters.AddWithValue("?", cinsiyet);
                        insertCmd.Parameters.AddWithValue("?", telefon);
                        insertCmd.Parameters.AddWithValue("?", mail);
                        insertCmd.Parameters.AddWithValue("?", sifre);

                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Hasta kaydı başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
        public static bool IsValidSifre(string sifre)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(sifre);
        }
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@(gmail|outlook|gazi|hotmail)\.(com|net|org|gov|edu)(\.tr)?$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        public static bool IsAllDigits(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        public void BtnHastaGirisi_Click(object sender, EventArgs e)
        {
            PatientLogPage frm = new PatientLogPage();
            formTransferHelper.TransferSizeAndLocation(this, frm);
            this.Hide();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK) { }
            this.Close();
        }
        public void BtnGeriRF_Click(object sender, EventArgs e)
        {
            PatientLogPage frm = new PatientLogPage();
            formTransferHelper.TransferSizeAndLocation(this, frm);
            this.Hide();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK) { }
            this.Close();
        }
        public void TxtMail_TextChanged(object sender, EventArgs e) { }
        public void TxtTcRF_TextChanged(object sender, EventArgs e) { }
    }
}