using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Hastalik_Tani_Destek_Sistemi.Properties;

namespace Hastalik_Tani_Destek_Sistemi
{
    partial class StartPage : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            SuspendLayout();
            


            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Hastalik_Tani_Destek_Sistemi.Properties.Resources.MainMenuBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            DoubleBuffered = true;
            Name = "StartPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hastalık Tanı Destek Sistemi";
            ResumeLayout(false);
        }
        #endregion

        //private Icon ConvertBitmapToIcon(string imagePath)
        //{
        //    using (Bitmap bitmap = new Bitmap(imagePath))
        //    {
        //        IntPtr hIcon = bitmap.GetHicon();
        //        Icon icon = Icon.FromHandle(hIcon);
        //        return icon;
        //    }
        //}
    }
}
