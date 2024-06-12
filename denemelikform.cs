using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hastalik_Tani_Destek_Sistemi
{ 
    public class CustomForm : Form
    {

        public CustomForm()
        {

            this.Resize += CustomForm_Resize;

            CustomMenu.AddMenu(this);
            HakkindaButonu.AddAboutButton(this);
            Versiyon.AddVersiyonLabel(this);
            GroupBox.AddGroupBox(this);
        }

        private void CustomForm_Resize(object sender, EventArgs e)
        {
        }
    }
}