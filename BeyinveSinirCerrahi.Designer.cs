using System;
using System.Drawing;
using System.Windows.Forms;
namespace Hastalik_Tani_Destek_Sistemi
{
    partial class BeyinveSinirCerrahi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkHeadache = new CheckBox();
            this.chkNumbness = new CheckBox();
            this.chkMemoryLoss = new CheckBox();
            this.chkSpeechDifficulty = new CheckBox();
            this.chkSeizures = new CheckBox();
            this.chkBalanceProblems = new CheckBox();
            this.chkVisionChanges = new CheckBox();
            this.chkWeakness = new CheckBox();
            this.chkTingling = new CheckBox();
            this.chkDifficultyWalking = new CheckBox();
            this.chkDizziness = new CheckBox();
            this.chkLossOfConsciousness = new CheckBox();
            this.chkLossOfMovement = new CheckBox();
            this.btnCheck = new Button();
            this.lblResult = new Label();
            this.SuspendLayout();
            // 
            // chkHeadache
            // 
            this.chkHeadache.AutoSize = true;
            this.chkHeadache.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkHeadache.Location = new Point(35, 28);
            this.chkHeadache.Name = "chkHeadache";
            this.chkHeadache.Size = new Size(90, 20);
            this.chkHeadache.TabIndex = 0;
            this.chkHeadache.Text = "Baş Ağrısı";
            this.chkHeadache.UseVisualStyleBackColor = true;
            // 
            // chkNumbness
            // 
            this.chkNumbness.AutoSize = true;
            this.chkNumbness.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkNumbness.Location = new Point(35, 55);
            this.chkNumbness.Name = "chkNumbness";
            this.chkNumbness.Size = new Size(91, 20);
            this.chkNumbness.TabIndex = 1;
            this.chkNumbness.Text = "Uyuşukluk";
            this.chkNumbness.UseVisualStyleBackColor = true;
            // 
            // chkMemoryLoss
            // 
            this.chkMemoryLoss.AutoSize = true;
            this.chkMemoryLoss.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkMemoryLoss.Location = new Point(35, 82);
            this.chkMemoryLoss.Name = "chkMemoryLoss";
            this.chkMemoryLoss.Size = new Size(104, 20);
            this.chkMemoryLoss.TabIndex = 2;
            this.chkMemoryLoss.Text = "Hafıza Kaybı";
            this.chkMemoryLoss.UseVisualStyleBackColor = true;
            // 
            // chkSpeechDifficulty
            // 
            this.chkSpeechDifficulty.AutoSize = true;
            this.chkSpeechDifficulty.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkSpeechDifficulty.Location = new Point(35, 109);
            this.chkSpeechDifficulty.Name = "chkSpeechDifficulty";
            this.chkSpeechDifficulty.Size = new Size(137, 20);
            this.chkSpeechDifficulty.TabIndex = 3;
            this.chkSpeechDifficulty.Text = "Konuşma Güçlüğü";
            this.chkSpeechDifficulty.UseVisualStyleBackColor = true;
            // 
            // chkSeizures
            // 
            this.chkSeizures.AutoSize = true;
            this.chkSeizures.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkSeizures.Location = new Point(35, 136);
            this.chkSeizures.Name = "chkSeizures";
            this.chkSeizures.Size = new Size(81, 20);
            this.chkSeizures.TabIndex = 4;
            this.chkSeizures.Text = "Nöbetler";
            this.chkSeizures.UseVisualStyleBackColor = true;
            // 
            // chkBalanceProblems
            // 
            this.chkBalanceProblems.AutoSize = true;
            this.chkBalanceProblems.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkBalanceProblems.Location = new Point(35, 163);
            this.chkBalanceProblems.Name = "chkBalanceProblems";
            this.chkBalanceProblems.Size = new Size(142, 20);
            this.chkBalanceProblems.TabIndex = 5;
            this.chkBalanceProblems.Text = "Denge Problemleri";
            this.chkBalanceProblems.UseVisualStyleBackColor = true;
            // 
            // chkVisionChanges
            // 
            this.chkVisionChanges.AutoSize = true;
            this.chkVisionChanges.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkVisionChanges.Location = new Point(35, 190);
            this.chkVisionChanges.Name = "chkVisionChanges";
            this.chkVisionChanges.Size = new Size(150, 20);
            this.chkVisionChanges.TabIndex = 6;
            this.chkVisionChanges.Text = "Görme Değişiklikleri";
            this.chkVisionChanges.UseVisualStyleBackColor = true;
            // 
            // chkWeakness
            // 
            this.chkWeakness.AutoSize = true;
            this.chkWeakness.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkWeakness.Location = new Point(35, 217);
            this.chkWeakness.Name = "chkWeakness";
            this.chkWeakness.Size = new Size(71, 20);
            this.chkWeakness.TabIndex = 7;
            this.chkWeakness.Text = "Zayıflık";
            this.chkWeakness.UseVisualStyleBackColor = true;
            // 
            // chkTingling
            // 
            this.chkTingling.AutoSize = true;
            this.chkTingling.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkTingling.Location = new Point(35, 244);
            this.chkTingling.Name = "chkTingling";
            this.chkTingling.Size = new Size(111, 20);
            this.chkTingling.TabIndex = 8;
            this.chkTingling.Text = "Karıncalanma";
            this.chkTingling.UseVisualStyleBackColor = true;
            // 
            // chkDifficultyWalking
            // 
            this.chkDifficultyWalking.AutoSize = true;
            this.chkDifficultyWalking.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkDifficultyWalking.Location = new Point(35, 271);
            this.chkDifficultyWalking.Name = "chkDifficultyWalking";
            this.chkDifficultyWalking.Size = new Size(123, 20);
            this.chkDifficultyWalking.TabIndex = 9;
            this.chkDifficultyWalking.Text = "Yürüme Zorluğu";
            this.chkDifficultyWalking.UseVisualStyleBackColor = true;
            // 
            // chkDizziness
            // 
            this.chkDizziness.AutoSize = true;
            this.chkDizziness.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkDizziness.Location = new Point(35, 298);
            this.chkDizziness.Name = "chkDizziness";
            this.chkDizziness.Size = new Size(110, 20);
            this.chkDizziness.TabIndex = 10;
            this.chkDizziness.Text = "Baş Dönmesi";
            this.chkDizziness.UseVisualStyleBackColor = true;
            // 
            // chkLossOfConsciousness
            // 
            this.chkLossOfConsciousness.AutoSize = true;
            this.chkLossOfConsciousness.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkLossOfConsciousness.Location = new Point(35, 325);
            this.chkLossOfConsciousness.Name = "chkLossOfConsciousness";
            this.chkLossOfConsciousness.Size = new Size(98, 20);
            this.chkLossOfConsciousness.TabIndex = 11;
            this.chkLossOfConsciousness.Text = "Bilinç Kaybı";
            this.chkLossOfConsciousness.UseVisualStyleBackColor = true;
            // 
            // chkLossOfMovement
            // 
            this.chkLossOfMovement.AutoSize = true;
            this.chkLossOfMovement.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.chkLossOfMovement.Location = new Point(35, 352);
            this.chkLossOfMovement.Name = "chkLossOfMovement";
            this.chkLossOfMovement.Size = new Size(114, 20);
            this.chkLossOfMovement.TabIndex = 12;
            this.chkLossOfMovement.Text = "Hareket Kaybı";
            this.chkLossOfMovement.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            //// 
            //this.btnCheck.Location = new Point(35, 379);
            //this.btnCheck.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            //this.btnCheck.Name = "btnCheck";
            //this.btnCheck.BackColor = Color.DodgerBlue;
            //this.btnCheck.Size = new Size(70, 23);
            //this.btnCheck.TabIndex = 13;
            //this.btnCheck.Text = "Kontrol Et";
            //this.btnCheck.UseVisualStyleBackColor = false;
            //this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            //// 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblResult.Location = new Point(35, 405);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new Size(0, 16);
            this.lblResult.TabIndex = 14;
            // 
            // BeyinveSinirCerrahi
            // 
            this.AutoScaleDimensions = new SizeF(8F, 17F);
            this.BackColor = Color.Snow;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(980, 551);
            this.Controls.Add(this.lblResult);
            //this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.chkLossOfMovement);
            this.Controls.Add(this.chkLossOfConsciousness);
            this.Controls.Add(this.chkDizziness);
            this.Controls.Add(this.chkDifficultyWalking);
            this.Controls.Add(this.chkTingling);
            this.Controls.Add(this.chkWeakness);
            this.Controls.Add(this.chkVisionChanges);
            this.Controls.Add(this.chkBalanceProblems);
            this.Controls.Add(this.chkSeizures);
            this.Controls.Add(this.chkSpeechDifficulty);
            this.Controls.Add(this.chkMemoryLoss);
            this.Controls.Add(this.chkNumbness);
            this.Controls.Add(this.chkHeadache);
            this.Name = "BeyinveSinirCerrahi";
            this.Text = "Beyin ve Sinir Cerrahisi Belirti Kontrolü";

            // Arka plan resmini ekleyin
            this.BackgroundImage = Hastalik_Tani_Destek_Sistemi.Properties.Resources.GeneralBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private CheckBox chkHeadache;
        private CheckBox chkNumbness;
        private CheckBox chkMemoryLoss;
        private CheckBox chkSpeechDifficulty;
        private CheckBox chkSeizures;
        private CheckBox chkBalanceProblems;
        private CheckBox chkVisionChanges;
        private CheckBox chkWeakness;
        private CheckBox chkTingling;
        private CheckBox chkDifficultyWalking;
        private CheckBox chkDizziness;
        private CheckBox chkLossOfConsciousness;
        private CheckBox chkLossOfMovement;
        private Button btnCheck;
        private Label lblResult;
       // private OneFormToAnother formTransferHelper;
    }
}