namespace Hastalik_Tani_Destek_Sistemi
{
    partial class DoctorMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewPatients;

        private RoundedButton BtnGeriDM;


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
            dataGridViewPatients = new DataGridView();
            BtnGeriDM = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPatients
            // 
            dataGridViewPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatients.Location = new Point(60, 13);
            dataGridViewPatients.Margin = new Padding(4, 4, 4, 4);
            dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewPatients.RowHeadersWidth = 62;
            dataGridViewPatients.Size = new Size(625, 324);
            dataGridViewPatients.TabIndex = 0;
            dataGridViewPatients.CellContentClick += dataGridViewPatients_CellContentClick;
            // 
            // BtnGeriDM
            // 
            BtnGeriDM.BackColor = Color.DodgerBlue;
            BtnGeriDM.BorderSize = 10;
            BtnGeriDM.ButtonImage = null;
            BtnGeriDM.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGeriDM.ForeColor = Color.White;
            BtnGeriDM.Location = new Point(4, 347);
            BtnGeriDM.Margin = new Padding(4, 6, 4, 6);
            BtnGeriDM.Name = "BtnGeriDM";
            BtnGeriDM.Size = new Size(94, 34);
            BtnGeriDM.TabIndex = 1;
            BtnGeriDM.Text = " ← ";
            BtnGeriDM.UseVisualStyleBackColor = false;
            BtnGeriDM.Click += BtnGeriDM_Click;
            // 
            // DoctorMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 394);
            Controls.Add(dataGridViewPatients);
            Controls.Add(BtnGeriDM);
            Margin = new Padding(4, 4, 4, 4);
            Name = "DoctorMenu";
            Text = "Doctor Form";

            this.BackgroundImage = Hastalik_Tani_Destek_Sistemi.Properties.Resources.GeneralBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).EndInit();
            ResumeLayout(false);


        }
    }
}
