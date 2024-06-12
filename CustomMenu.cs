using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Hastalik_Tani_Destek_Sistemi
{
    public static class CustomMenu
    {
        private static Button homeButton;
        private static Button exitButton;
        private static OneFormToAnother formTransferHelper = new OneFormToAnother();

        public static void AddMenu(Form form)
        {
            System.Windows.Forms.Timer menuTimer = new System.Windows.Forms.Timer();
            bool menuVisible = false;

            Button menuButton = new Button();
            menuButton.Text = "Menü";
            menuButton.Size = new Size(100, 45);
            menuButton.BackColor = Color.Snow;
            menuButton.Font = new Font(menuButton.Font.FontFamily, 10, FontStyle.Bold);
            menuButton.AutoSize = true;
            menuButton.Location = new Point(10, 10);
            menuButton.Click += (sender, e) => ToggleMenu();
            form.Controls.Add(menuButton);

            homeButton = new Button();
            homeButton.Text = "Anasayfa";
            homeButton.Size = new Size(100, 38); // Genişliği artırdık
            homeButton.Location = new Point(menuButton.Left, 55);
            homeButton.Click += (sender, e) => HandleHomeButtonClick(form);
            homeButton.Visible = false;
            form.Controls.Add(homeButton);

            exitButton = new Button();
            exitButton.Text = "Çıkış";
            exitButton.Size = new Size(100, 38); // Aynı genişlikte yaptık
            exitButton.Location = new Point(menuButton.Left, 85);
            exitButton.Click += (sender, e) => Application.Exit();
            exitButton.Visible = false;
            form.Controls.Add(exitButton);

            void ToggleMenu()
            {
                menuVisible = !menuVisible;
                homeButton.Visible = menuVisible;
                exitButton.Visible = menuVisible;
            }
        }

        public static void AddMenu(Panel panel)
        {
            System.Windows.Forms.Timer menuTimer = new System.Windows.Forms.Timer();
            bool menuVisible = false;

            Button menuButton = new Button();
            menuButton.Text = "Menü";
            menuButton.Size = new Size(100, 45);
            menuButton.BackColor = Color.Snow;
            menuButton.Font = new Font(menuButton.Font.FontFamily, 10, FontStyle.Bold);
            menuButton.AutoSize = true;
            menuButton.Location = new Point(10, 10);
            menuButton.Click += (sender, e) => ToggleMenu();
            panel.Controls.Add(menuButton);

            homeButton = new Button();
            homeButton.Text = "Ana Sayfa";
            homeButton.Size = new Size(100, 38); // Genişliği artırdık
            homeButton.Location = new Point(menuButton.Left, 55);
            homeButton.Click += (sender, e) => HandleHomeButtonClick(panel.FindForm());
            homeButton.Visible = false;
            panel.Controls.Add(homeButton);

            exitButton = new Button();
            exitButton.Text = "Çıkış";
            exitButton.Size = new Size(100, 38); // Aynı genişlikte yaptık
            exitButton.Location = new Point(menuButton.Left, 85);
            exitButton.Click += (sender, e) => Application.Exit();
            exitButton.Visible = false;
            panel.Controls.Add(exitButton);

            void ToggleMenu()
            {
                menuVisible = !menuVisible;
                homeButton.Visible = menuVisible;
                exitButton.Visible = menuVisible;
            }
        }
        private static void HandleHomeButtonClick(Form currentForm)
        {
            StartPage startPage = new StartPage();
            formTransferHelper.TransferSizeAndLocation(currentForm, startPage);
            currentForm.Hide();
            startPage.ShowDialog();
            if (startPage.DialogResult == DialogResult.OK) { }
            currentForm.Close();
        }
    }
}