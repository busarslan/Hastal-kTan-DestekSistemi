using System;
using System.Drawing;
using System.Windows.Forms;
namespace Hastalik_Tani_Destek_Sistemi
{
    partial class ÇocukCerrahisi
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

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.chkAbdominalPain = new CheckBox();
            this.chkUrinaryTractInfection = new CheckBox();
            this.chkVomiting = new CheckBox();
            this.chkDiarrhea = new CheckBox();
            this.chkUrinaryIncontinence = new CheckBox();
            this.chkInguinalHernia = new CheckBox();
            this.chkHernia = new CheckBox();
            this.chkUrinaryRetention = new CheckBox();
            this.chkUrinaryStone = new CheckBox();
            this.btnCheck = new Button();
            this.lblResult = new Label();
            this.SuspendLayout();
            // 
            // chkAbdominalPain
            // 
            this.chkAbdominalPain.AutoSize = true;
            this.chkAbdominalPain.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkAbdominalPain.Location = new Point(35, 28);
            this.chkAbdominalPain.Name = "chkAbdominalPain";
            this.chkAbdominalPain.Size = new Size(101, 20);
            this.chkAbdominalPain.TabIndex = 0;
            this.chkAbdominalPain.Text = "Karın Ağrısı";
            this.chkAbdominalPain.UseVisualStyleBackColor = true;
            // 
            // chkUrinaryTractInfection
            // 
            this.chkUrinaryTractInfection.AutoSize = true;
            this.chkUrinaryTractInfection.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkUrinaryTractInfection.Location = new Point(35, 55);
            this.chkUrinaryTractInfection.Name = "chkUrinaryTractInfection";
            this.chkUrinaryTractInfection.Size = new Size(181, 20);
            this.chkUrinaryTractInfection.TabIndex = 1;
            this.chkUrinaryTractInfection.Text = "İdrar Yolu Enfeksiyonu";
            this.chkUrinaryTractInfection.UseVisualStyleBackColor = true;
            // 
            // chkVomiting
            // 
            this.chkVomiting.AutoSize = true;
            this.chkVomiting.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkVomiting.Location = new Point(35, 82);
            this.chkVomiting.Name = "chkVomiting";
            this.chkVomiting.Size = new Size(75, 20);
            this.chkVomiting.TabIndex = 2;
            this.chkVomiting.Text = "Kusma";
            this.chkVomiting.UseVisualStyleBackColor = true;
            // 
            // chkDiarrhea
            // 
            this.chkDiarrhea.AutoSize = true;
            this.chkDiarrhea.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkDiarrhea.Location = new Point(35, 109);
            this.chkDiarrhea.Name = "chkDiarrhea";
            this.chkDiarrhea.Size = new Size(65, 20);
            this.chkDiarrhea.TabIndex = 3;
            this.chkDiarrhea.Text = "İshal";
            this.chkDiarrhea.UseVisualStyleBackColor = true;
            // 
            // chkUrinaryIncontinence
            // 
            this.chkUrinaryIncontinence.AutoSize = true;
            this.chkUrinaryIncontinence.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkUrinaryIncontinence.Location = new Point(35, 136);
            this.chkUrinaryIncontinence.Name = "chkUrinaryIncontinence";
            this.chkUrinaryIncontinence.Size = new Size(129, 20);
            this.chkUrinaryIncontinence.TabIndex = 4;
            this.chkUrinaryIncontinence.Text = "İdrar Kaçırma";
            this.chkUrinaryIncontinence.UseVisualStyleBackColor = true;
            // 
            // chkInguinalHernia
            // 
            this.chkInguinalHernia.AutoSize = true;
            this.chkInguinalHernia.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkInguinalHernia.Location = new Point(35, 163);
            this.chkInguinalHernia.Name = "chkInguinalHernia";
            this.chkInguinalHernia.Size = new Size(118, 20);
            this.chkInguinalHernia.TabIndex = 5;
            this.chkInguinalHernia.Text = "İnguinal Herni";
            this.chkInguinalHernia.UseVisualStyleBackColor = true;
            // 
            // chkHernia
            // 
            this.chkHernia.AutoSize = true;
            this.chkHernia.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkHernia.Location = new Point(35, 190);
            this.chkHernia.Name = "chkHernia";
            this.chkHernia.Size = new Size(61, 20);
            this.chkHernia.TabIndex = 6;
            this.chkHernia.Text = "Fıtık";
            this.chkHernia.UseVisualStyleBackColor = true;
            // 
            // chkUrinaryRetention
            // 
            this.chkUrinaryRetention.AutoSize = true;
            this.chkUrinaryRetention.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkUrinaryRetention.Location = new Point(35, 217);
            this.chkUrinaryRetention.Name = "chkUrinaryRetention";
            this.chkUrinaryRetention.Size = new Size(163, 20);
            this.chkUrinaryRetention.TabIndex = 7;
            this.chkUrinaryRetention.Text = "İdrar Retansiyonu";
            this.chkUrinaryRetention.UseVisualStyleBackColor = true;
            // 
            // chkUrinaryStone
            // 
            this.chkUrinaryStone.AutoSize = true;
            this.chkUrinaryStone.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkUrinaryStone.Location = new Point(35, 244);
            this.chkUrinaryStone.Name = "chkUrinaryStone";
            this.chkUrinaryStone.Size = new Size(132, 20);
            this.chkUrinaryStone.TabIndex = 8;
            this.chkUrinaryStone.Text = "İdrar Yolu Taşı";
            this.chkUrinaryStone.UseVisualStyleBackColor = true;
             
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblResult.Location = new Point(35, 333);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new Size(0, 16);
            this.lblResult.TabIndex = 10;
            // 
            // CocukCerrahisi
            // 
            this.AutoScaleDimensions = new SizeF(8F, 17F);
            BackColor = Color.Snow;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(606, 373);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.chkUrinaryStone);
            this.Controls.Add(this.chkUrinaryRetention);
            this.Controls.Add(this.chkHernia);
            this.Controls.Add(this.chkInguinalHernia);
            this.Controls.Add(this.chkUrinaryIncontinence);
            this.Controls.Add(this.chkDiarrhea);
            this.Controls.Add(this.chkVomiting);
            this.Controls.Add(this.chkUrinaryTractInfection);
            this.Controls.Add(this.chkAbdominalPain);
            this.Name = "CocukCerrahisi";
            this.Text = "Çocuk Cerrahisi Belirti Kontrolü";

            // Arka plan resmini ekleyin
            this.BackgroundImage = Hastalik_Tani_Destek_Sistemi.Properties.Resources.GeneralBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkAbdominalPain;
        private CheckBox chkUrinaryTractInfection;
        private CheckBox chkVomiting;
        private CheckBox chkDiarrhea;
        private CheckBox chkUrinaryIncontinence;
        private CheckBox chkInguinalHernia;
        private CheckBox chkHernia;
        private CheckBox chkUrinaryRetention;
        private CheckBox chkUrinaryStone;
        private Button btnCheck;
        private Label lblResult;
    }
}