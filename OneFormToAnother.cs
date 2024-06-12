using System.Windows.Forms;

namespace Hastalik_Tani_Destek_Sistemi
{
    public class OneFormToAnother
    {
        public void TransferSizeAndLocation(Form sourceForm, Form targetForm)
        {
            targetForm.Width = sourceForm.Width;
            targetForm.Height = sourceForm.Height;
            targetForm.StartPosition = FormStartPosition.Manual;
            targetForm.Location = sourceForm.Location;
        }
    }
}
