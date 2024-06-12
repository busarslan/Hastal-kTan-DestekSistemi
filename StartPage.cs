using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using Hastalik_Tani_Destek_Sistemi.Properties;

namespace Hastalik_Tani_Destek_Sistemi
{
    public partial class StartPage : Form
    {
        public ObjectFontAdjustment fontAdjustment;
        public ObjectResize objectResize;
        public CircleButtonStartPage circle_button;
        public RoundedLabel firstLabel;
        public RoundedLabel secondLabel;
        public RoundedLabel thirdLabel;

        private int initialClientWidth;
        private int initialClientHeight;
        private bool isDragging = false;
        private Point dragStartPoint;
        private bool messageBoxShown = false;
        private System.Windows.Forms.Timer blinkTimer;
        private System.Windows.Forms.Timer returnTimer;
        private int blinkStep = 0;
        private PictureBox[] leftArrows;
        private PictureBox[] rightArrows;
        private Point returnStartPosition;
        private Point returnTargetPosition;
        private int returnStep;
        private int returnTotalSteps = 30;
        private OneFormToAnother formTransferHelper;
        private CustomForm dene;

        public StartPage()
        {
            formTransferHelper = new OneFormToAnother();
            IconHelper.SetAppIcon(this);
            Program.EnableDoubleBuffering(this);
            dene = new CustomForm();
            InitializeComponent();
            fontAdjustment = new ObjectFontAdjustment();
            objectResize = new ObjectResize();

            Image labelBackgroundImage = Hastalik_Tani_Destek_Sistemi.Properties.Resources.Random1Background;

            firstLabel = new RoundedLabel
            {
                BorderColor = Color.FromArgb(56, 182, 255),
                BorderWidth = 8,
                ForeColor = Color.Blue,
                AutoSize = false,
                Name = "Arama",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Montserrat", 24, FontStyle.Bold), 
                Text = "Hastalýk Taný Destek Sistemi",
                LabelImage = labelBackgroundImage,
            }; Controls.Add(firstLabel);

            secondLabel = new RoundedLabel
            {
                BackColor = Color.CornflowerBlue,
                ForeColor = Color.Beige,
                BorderWidth = 8,
                BorderColor = Color.FromArgb(56, 182, 255),
                AutoSize = false,
                Name = "Arama",
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Doktor Giriþi",
                Font = new Font("Arial", 15)
            }; Controls.Add(secondLabel);

            thirdLabel = new RoundedLabel
            {
                BackColor = Color.CornflowerBlue,
                ForeColor = Color.Beige,
                BorderWidth = 8,
                BorderColor = Color.FromArgb(56, 182, 255),
                AutoSize = false,
                Name = "Arama",
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Hasta Giriþi",
                Font = new Font("Arial", 15)
            }; Controls.Add(thirdLabel);

            circle_button = new CircleButtonStartPage
            {
                BackColor = Color.Azure,
                ButtonImage = Hastalik_Tani_Destek_Sistemi.Properties.Resources.CircleSlidingButton,
        }; this.Controls.Add(circle_button);

            circle_button.MouseDown += CircleButton_MouseDown;
            circle_button.MouseMove += CircleButton_MouseMove;
            circle_button.MouseUp += CircleButton_MouseUp;

            this.Resize += StartPage_Resize;
            this.ClientSizeChanged += new EventHandler(StartPage_ClientSizeChanged);
            initialClientWidth = this.ClientSize.Width;
            initialClientHeight = this.ClientSize.Height;

            leftArrows = new PictureBox[3];
            rightArrows = new PictureBox[3];

            for (int i = 0; i < 3; i++)
            {
                leftArrows[i] = CreateArrowLeft();
                rightArrows[i] = CreateArrowRight();
                Controls.Add(leftArrows[i]);
                Controls.Add(rightArrows[i]);
            }

            blinkTimer = new System.Windows.Forms.Timer();
            blinkTimer.Interval = 450;
            blinkTimer.Tick += BlinkTimer_Tick;
            blinkTimer.Start();

            returnTimer = new System.Windows.Forms.Timer();
            returnTimer.Interval = 61;
            returnTimer.Tick += ReturnTimer_Tick;

            ResizeComponents(initialClientWidth, initialClientHeight);
        }

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            blinkStep = (blinkStep + 1) % 2;
            for (int i = 0; i < 3; i++)
            {
                leftArrows[i].Visible = (i == blinkStep);
                rightArrows[i].Visible = (i == blinkStep);
            }
        }

        private PictureBox CreateArrowLeft()
        {
            PictureBox arrow = new PictureBox
            {
                Size = new Size(this.ClientSize.Width / 10, this.ClientSize.Height / 10),
                Image = Hastalik_Tani_Destek_Sistemi.Properties.Resources.Arrow_left_icon,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent,
            };
            return arrow;
        }

        private PictureBox CreateArrowRight()
        {
            PictureBox arrow = new PictureBox
            {
                Size = new Size(this.ClientSize.Width / 10, this.ClientSize.Height / 10),
                Image = Hastalik_Tani_Destek_Sistemi.Properties.Resources.Arrow_right_icon,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent,
            };
            return arrow;
        }

        private void PositionArrows()
        {
            int arrowSpacing = this.ClientSize.Width / 400;
            int centerX = this.ClientSize.Width / 2 - circle_button.Width / 2;
            int arrowY = (this.ClientSize.Height / 2) - (leftArrows[0].Height / 2);

            for (int i = 0; i < 3; i++)
            {
                int arrowLeftX = centerX - (i + 1) * (leftArrows[i].Width + arrowSpacing);
                int arrowRightX = centerX + circle_button.Width + (i + 1) * arrowSpacing + (i * rightArrows[i].Width);

                leftArrows[i].Location = new Point(arrowLeftX, arrowY);
                rightArrows[i].Location = new Point(arrowRightX, arrowY);
            }
        }

        private void StartPage_ClientSizeChanged(object sender, EventArgs e)
        {
            initialClientWidth = this.ClientSize.Width;
            initialClientHeight = this.ClientSize.Height;
            StopReturnAnimationAndCenterButton();
            ResizeComponents(initialClientWidth, initialClientHeight);
        }

        private void CircleButton_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragStartPoint = e.Location;
            returnTimer.Stop();
        }

        private async void CircleButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                circle_button.Left += e.X - dragStartPoint.X;
                circle_button.Left = Math.Max(0, Math.Min(circle_button.Left, this.ClientSize.Width - circle_button.Width));

                PositionArrows();

                if (!messageBoxShown)
                {
                    if (circle_button.Left < this.ClientSize.Width / 4 - circle_button.Width / 2)
                    {
                        messageBoxShown = true;
                        isDragging = false;
                        DoctorLogPage doctor_LP = new DoctorLogPage();
                        formTransferHelper.TransferSizeAndLocation(this, doctor_LP);
                        this.Hide();
                        doctor_LP.ShowDialog();
                        if (doctor_LP.DialogResult == DialogResult.OK)
                        { }
                        this.Close();
                        ResetButtonPosition();
                    }
                    else if (circle_button.Left > this.ClientSize.Width * 3 / 4 - circle_button.Width / 2)
                    {
                        messageBoxShown = true;
                        isDragging = false;
                        PatientLogPage patient_LP = new PatientLogPage();
                        formTransferHelper.TransferSizeAndLocation(this, patient_LP);
                        this.Hide();
                        patient_LP.ShowDialog();
                        if (patient_LP.DialogResult == DialogResult.OK)
                        { }
                        this.Close();
                        ResetButtonPosition();
                    }
                }
            }
        }

        private void CircleButton_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            messageBoxShown = false;
            StartReturnAnimation();
        }

        private void StartReturnAnimation()
        {
            returnStartPosition = circle_button.Location;
            returnTargetPosition = new Point(this.ClientSize.Width / 2 - circle_button.Width / 2, this.ClientSize.Height / 2 - circle_button.Height / 2);
            returnStep = 0;
            returnTimer.Start();
        }

        private void ReturnTimer_Tick(object sender, EventArgs e)
        {
            if (returnStep < returnTotalSteps)
            {
                float t = (float)returnStep / returnTotalSteps;
                circle_button.Left = (int)(returnStartPosition.X + t * (returnTargetPosition.X - returnStartPosition.X));
                circle_button.Top = (int)(returnStartPosition.Y + t * (returnTargetPosition.Y - returnStartPosition.Y));
                returnStep++;
            }
            else
            {
                returnTimer.Stop();
                circle_button.Location = returnTargetPosition;
            }
        }

        private void ResetButtonPosition()
        {
            int centerX = this.ClientSize.Width / 2 - circle_button.Width / 2;
            int centerY = this.ClientSize.Height / 2 - circle_button.Height / 2;
            circle_button.Location = new Point(centerX, centerY);
            PositionArrows();
        }

        private void StartPage_Resize(object sender, EventArgs e)
        {
            this.ClientSize = new Size(Math.Max(this.ClientSize.Width, 800), Math.Max(this.ClientSize.Height, 450));
            StopReturnAnimationAndCenterButton();
            ResizeComponents(initialClientWidth, initialClientHeight);
        }

        private void ResizeComponents(float clientSizeWidth, float clientSizeHeight)
        {
            objectResize.ResizeMainLabel_SP(firstLabel, clientSizeWidth, clientSizeHeight);
            objectResize.ResizeNormalLabel_SP(secondLabel, clientSizeWidth, clientSizeHeight, 0.25);
            objectResize.ResizeNormalLabel_SP(thirdLabel, clientSizeWidth, clientSizeHeight, 0.75);
            objectResize.ResizeCenterCircle_SP(circle_button, clientSizeWidth, clientSizeHeight);
            fontAdjustment.AdjustLabelFontSize_SP(firstLabel, clientSizeWidth);
            fontAdjustment.AdjustDownLabelFontSize_SP(secondLabel, clientSizeWidth);
            fontAdjustment.AdjustDownLabelFontSize_SP(thirdLabel, clientSizeWidth);
            PositionArrows();
        }

        private void StopReturnAnimationAndCenterButton()
        {
            returnTimer.Stop();
            ResetButtonPosition();
        }
    }
}