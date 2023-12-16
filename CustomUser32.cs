using System.Runtime.InteropServices;
namespace WallpaperLibrary
{
    internal class CustomUser32
    {
        /// <summary>
        /// This enumeration is used to set WALLPAPER.
        /// </summary>
        public enum SPI_KEY : int
        {
            SPI_SETDESKWALLPAPER = 20,
            SPIF_UPDATEINIFILE = 0x01,
            SPIF_SENDWININICHANGE = 0x02
        }
        // this is the system DLL for doing wallpaper stuff
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        /// <summary>
        /// This method clean 
        /// </summary>
        public  static void clearWallpaper() => SystemParametersInfo((int)SPI_KEY.SPI_SETDESKWALLPAPER, 0, "", (int)SPI_KEY.SPIF_UPDATEINIFILE | (int)SPI_KEY.SPIF_SENDWININICHANGE);
    }
}