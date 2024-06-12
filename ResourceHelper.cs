using System.Drawing;  // Needed for Image type
using Hastalik_Tani_Destek_Sistemi.Properties;

namespace Hastalik_Tani_Destek_Sistemi
{
    public static class ResourceHelper
    {
        // This method retrieves an image by its name from the Resources.
        public static Image GetImage(string resourceName)
        {
            // Using reflection to dynamically get the resource property
            return (Image)Properties.Resources.ResourceManager.GetObject(resourceName);
        }
    }
}
