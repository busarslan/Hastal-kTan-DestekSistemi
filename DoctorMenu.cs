using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static Hastalik_Tani_Destek_Sistemi.DoctorLogPage;

namespace Hastalik_Tani_Destek_Sistemi
{
    public partial class DoctorMenu : Form
    {
        private Label baslikDktr;
        private PictureBox pictureBox;
        private OleDbConnection connection;
        private string doktorTC = "";
        private OneFormToAnother TransferSizeAndLocation;

        public DoctorMenu()
        {
            IconHelper.SetAppIcon(this);
            Program.EnableDoubleBuffering(this);
            InitializeComponent();
            TransferSizeAndLocation = new OneFormToAnother();
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\busbu\\source\\repos\\Bgenone\\HTDSnew\\hastaneproje.accdb");
            this.doktorTC = DoctorInfo.TCNo;
            LoadPatientData();
            this.Resize += new EventHandler(DoctorMenu_Resize);
            dataGridViewPatients.BackgroundColor = System.Drawing.Color.Snow;
            CustomMenu.AddMenu(this);
            HakkindaButonu.AddAboutButton(this);
            GroupBox.AddGroupBox(this);
            InitializeLabelDktr();
            InitializePictureBox();
            RepositionControls();
        }
        private void InitializePictureBox()
        {
            pictureBox = new PictureBox
            {
                Size = new Size(80, 80),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.Zoom
            };
           Controls.Add(pictureBox);

            pictureBox.Image = Hastalik_Tani_Destek_Sistemi.Properties.Resources.BlankProfilePicture;

            pictureBox.Paint += new PaintEventHandler(PictureBox_Paint);
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            if (picBox.Image != null)
            {
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, picBox.Width, picBox.Height);
                picBox.Region = new Region(path);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.SetClip(path);
                e.Graphics.DrawImage(picBox.Image, 0, 0, picBox.Width, picBox.Height);
            }
        }

        private void InitializeLabelDktr()  // alt alan etiketi
        {
            baslikDktr = new Label();
            // Doktor bilgisini Access veritabanından çekmek için bir sorgu oluştur
            string doktorBilgisiSorgusu = "SELECT isim, soyisim FROM doktorlar WHERE TCNo = @TCKimlik";
            using (OleDbCommand cmd = new OleDbCommand(doktorBilgisiSorgusu, connection))
            {
                cmd.Parameters.AddWithValue("@TCKimlik", doktorTC);
                connection.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) // Eğer bir sonuç varsa
                    {
                        string doktorIsim = reader["isim"].ToString();
                        string doktorSoyisim = reader["soyisim"].ToString();
                        baslikDktr.Text = $"Dr. {doktorIsim} {doktorSoyisim}"; // İsim ve soyisim bilgisini kullanarak etiketi güncelle
                    }
                }
                connection.Close();
            }
            baslikDktr.AutoSize = true;
            this.baslikDktr.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            baslikDktr.BackColor = Color.Snow;
            this.Controls.Add(baslikDktr);
        }

        private void LoadPatientData()
        {
            try
            {
                connection.Open();
                string query = "SELECT isim, soyisim,TCNo, yaş, cinsiyet, telefon, mail, hastalık FROM hastalar WHERE uzmanlık = (SELECT uzmanlık FROM doktorlar WHERE TCNo = @TCKimlik)";
                OleDbCommand cmd = new OleDbCommand(query, connection);
                cmd.Parameters.AddWithValue("@TCKimlik", doktorTC);

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewPatients.DataSource = dt;

                // Adjust column widths
                dataGridViewPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Optionally set specific columns to auto size or fixed size
                dataGridViewPatients.Columns["hastalık"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewPatients.Columns["isim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewPatients.Columns["soyisim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewPatients.Columns["TCNo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewPatients.Columns["yaş"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewPatients.Columns["cinsiyet"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewPatients.Columns["telefon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewPatients.Columns["mail"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void DoctorMenu_Load(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void DoctorMenu_Resize(object sender, EventArgs e)
        {
            this.ClientSize = new Size(Math.Max(this.ClientSize.Width, 800), Math.Max(this.ClientSize.Height, 450));
            ResizeControls();
        }

        private void ResizeControls()
        {
            int newWidth = this.ClientSize.Width - 40; // Leave some margin on both sides
            int newHeight = this.ClientSize.Height - 55;
            
            newWidth = Math.Min(newWidth, this.ClientSize.Width - 20);  // Leave some margin
            newHeight = Math.Min(newHeight, this.ClientSize.Height - 20);  // Leave some margin

            // Center the DataGridView within the form
            dataGridViewPatients.Size = new Size(Convert.ToInt32(newWidth/0.99f), newHeight/2);
            dataGridViewPatients.Location = new Point((this.ClientSize.Width - newWidth) / 2, Convert.ToInt32((this.ClientSize.Height - newHeight) / 0.27f));
            float clientSizeWidthProp = (float)this.ClientSize.Width;
            float clientSizeHeightProp = (float)this.ClientSize.Height;
            ResizeButtonToBottomLeft(BtnGeriDM, clientSizeWidthProp, clientSizeHeightProp);


            Versiyon.AddVersiyonLabel(this);
        }
        private void RepositionControls()
        {
            float widthFactor = (float)ClientSize.Width / 800;
            float heightFactor = (float)ClientSize.Height / 450;

            int topMargin = (int)(50 * heightFactor); // Kullanıcı label'ı için
            int pictureBoxHeight = (int)(90 * heightFactor); // PictureBox için
            topMargin += pictureBoxHeight + (int)(10 * heightFactor);
            int baslikDktrX = (int)(175 * widthFactor);
            int baslikDktrY = (int)(160 * heightFactor);
            baslikDktr.Location = new Point(baslikDktrX, baslikDktrY);
            baslikDktr.Font = new Font(baslikDktr.Font.FontFamily, 40 * Math.Min(widthFactor, heightFactor));

            int pictureBoxX = (int)(30 * widthFactor);
            int pictureBoxY = (int)(100 * heightFactor);
            pictureBox.Location = new Point(pictureBoxX, pictureBoxY);
        }

            private void ResizeButtonToBottomLeft(RoundedButton button, float widthProp, float heightProp)
        {
            button.Size = new Size((int)(widthProp / 18), Math.Max((int)(heightProp / 13), 50));
            button.Location = new Point((int)(widthProp / 19), (int)(heightProp - Math.Max((int)(heightProp / 10), 70)));

            float fontSize = button.Width / 5.6f;
            button.Font = new Font(button.Font.FontFamily, fontSize, FontStyle.Bold);
        }
        private void BtnGeriDM_Click(object sender, EventArgs e)
        {
            DoctorLogPage toDLP = new DoctorLogPage();
            TransferSizeAndLocation.TransferSizeAndLocation(this, toDLP);
            this.Hide();
            toDLP.ShowDialog();
            this.Close();
        }

        private void dataGridViewPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}