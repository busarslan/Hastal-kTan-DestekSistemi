namespace Hastalik_Tani_Destek_Sistemi
{
    partial class GöğüsHastalıkları
    {
        private System.ComponentModel.IContainer components = null;

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
            this.chkCough = new System.Windows.Forms.CheckBox();
            this.chkChestPain = new System.Windows.Forms.CheckBox();
            this.chkShortnessOfBreath = new System.Windows.Forms.CheckBox();
            this.chkWheezing = new System.Windows.Forms.CheckBox();
            this.chkSputum = new System.Windows.Forms.CheckBox();
            this.chkFatigue = new System.Windows.Forms.CheckBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkCough
            // 
            this.chkCough.AutoSize = true;
            this.chkCough.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkCough.Location = new System.Drawing.Point(35, 28);
            this.chkCough.Name = "chkCough";
            this.chkCough.Size = new System.Drawing.Size(78, 20);
            this.chkCough.TabIndex = 0;
            this.chkCough.Text = "Öksürük";
            this.chkCough.UseVisualStyleBackColor = true;
            // 
            // chkChestPain
            // 
            this.chkChestPain.AutoSize = true;
            this.chkChestPain.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkChestPain.Location = new System.Drawing.Point(35, 55);
            this.chkChestPain.Name = "chkChestPain";
            this.chkChestPain.Size = new System.Drawing.Size(106, 20);
            this.chkChestPain.TabIndex = 1;
            this.chkChestPain.Text = "Göğüs Ağrısı";
            this.chkChestPain.UseVisualStyleBackColor = true;
            // 
            // chkShortnessOfBreath
            // 
            this.chkShortnessOfBreath.AutoSize = true;
            this.chkShortnessOfBreath.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkShortnessOfBreath.Location = new System.Drawing.Point(35, 82);
            this.chkShortnessOfBreath.Name = "chkShortnessOfBreath";
            this.chkShortnessOfBreath.Size = new System.Drawing.Size(107, 20);
            this.chkShortnessOfBreath.TabIndex = 2;
            this.chkShortnessOfBreath.Text = "Nefes Darlığı";
            this.chkShortnessOfBreath.UseVisualStyleBackColor = true;
            // 
            // chkWheezing
            // 
            this.chkWheezing.AutoSize = true;
            this.chkWheezing.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkWheezing.Location = new System.Drawing.Point(35, 109);
            this.chkWheezing.Name = "chkWheezing";
            this.chkWheezing.Size = new System.Drawing.Size(58, 20);
            this.chkWheezing.TabIndex = 3;
            this.chkWheezing.Text = "Hırıltı";
            this.chkWheezing.UseVisualStyleBackColor = true;
            // 
            // chkSputum
            // 
            this.chkSputum.AutoSize = true;
            this.chkSputum.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkSputum.Location = new System.Drawing.Point(35, 136);
            this.chkSputum.Name = "chkSputum";
            this.chkSputum.Size = new System.Drawing.Size(76, 20);
            this.chkSputum.TabIndex = 4;
            this.chkSputum.Text = "Balgam";
            this.chkSputum.UseVisualStyleBackColor = true;
            // 
            // chkFatigue
            // 
            this.chkFatigue.AutoSize = true;
            this.chkFatigue.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkFatigue.Location = new System.Drawing.Point(35, 163);
            this.chkFatigue.Name = "chkFatigue";
            this.chkFatigue.Size = new System.Drawing.Size(89, 20);
            this.chkFatigue.TabIndex = 5;
            this.chkFatigue.Text = "Yorgunluk";
            this.chkFatigue.UseVisualStyleBackColor = true;
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblResult.Location = new System.Drawing.Point(35, 216);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 7;
            // 
            // GöğüsHastalıkları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.BackColor = Color.Snow;
            this.ClientSize = new System.Drawing.Size(467, 278);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.chkFatigue);
            this.Controls.Add(this.chkSputum);
            this.Controls.Add(this.chkWheezing);
            this.Controls.Add(this.chkShortnessOfBreath);
            this.Controls.Add(this.chkChestPain);
            this.Controls.Add(this.chkCough);
            this.Name = "GöğüsHastalıkları";
            this.Text = "Göğüs Hastalıkları Belirti Kontrolü";

            // Arka plan resmini ekleyin
            this.BackgroundImage = Hastalik_Tani_Destek_Sistemi.Properties.Resources.GeneralBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.CheckBox chkCough;
        private System.Windows.Forms.CheckBox chkChestPain;
        private System.Windows.Forms.CheckBox chkShortnessOfBreath;
        private System.Windows.Forms.CheckBox chkWheezing;
        private System.Windows.Forms.CheckBox chkSputum;
        private System.Windows.Forms.CheckBox chkFatigue;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResult;
    }
}