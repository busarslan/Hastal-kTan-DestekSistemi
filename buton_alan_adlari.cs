using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Hastalik_Tani_Destek_Sistemi
{
    internal class CustomButton : Button
    {
        private float initialWidth;
        private float initialHeight;
        private float initialFontSize;
        public string FormName { get; private set; }
        public CustomButton(string displayName, string formName, Point initialLocation, Size size)
        {
            this.Text = displayName;
            this.FormName = formName;
            this.Size = size;
            this.Location = initialLocation;
            this.initialWidth = size.Width;
            this.initialHeight = size.Height;
            this.initialFontSize = this.Font.Size;

            this.Click += new EventHandler(Button_Click);
            this.ParentChanged += (sender, e) =>
            {
                if (this.Parent != null)
                {
                    this.Parent.Resize += new EventHandler(Form_Resize);
                }
            };
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Type formType = Assembly.GetExecutingAssembly().GetType($"Hastalik_Tani_Destek_Sistemi.{FormName}");
            if (formType != null)
            {
                            
                Form formInstance = (Form)Activator.CreateInstance(formType);
                formInstance.Show();
            }
            else
            {
                MessageBox.Show($"Form '{FormName}' not found.");
            }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                float widthRatio = (float)this.Parent.ClientSize.Width / 800; 
                float heightRatio = (float)this.Parent.ClientSize.Height / 450; 
                this.Size = new Size(
                    (int)(initialWidth * widthRatio),
                    (int)(initialHeight * heightRatio)
                );
            }
        }
    }
}