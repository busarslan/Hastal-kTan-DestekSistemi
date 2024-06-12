using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hastalik_Tani_Destek_Sistemi
{
    public static class IconHelper
    {
        private static Icon appIcon;

        static IconHelper()
        {
            // .resx dosyanızdaki ICO kaynağının adı burada 'HTDS_Logo_Icon' olarak varsayılmıştır
            appIcon = Properties.Resources.HTDS_Logo;
        }

        public static void SetAppIcon(Form form)
        {
            if (appIcon != null)
            {
                form.Icon = appIcon;
            }
        }
    }
}