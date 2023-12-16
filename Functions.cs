using System;

namespace WallpaperLibrary
{
    public class Functions
    {
        public String SetWallPaper(string filePath, int indexMonitor)
        {
            IDesktopWallpaper wallpaper = (IDesktopWallpaper)(new DesktopWallpaperClass());
            wallpaper.SetWallpaper(wallpaper.GetMonitorDevicePathAt((uint)indexMonitor), filePath);
            return $"Load img  {filePath} over monitor {indexMonitor.ToString()}" ;
        }
        public string SetWallPaperSeqn(string file)
        {

            var wallpaper = (IDesktopWallpaper)(new DesktopWallpaperClass());
            uint monitorTotal = wallpaper.GetMonitorDevicePathCount();
            for (uint i = 0; i < monitorTotal; i++)
            {
                //Console.Write($"Load sqn img  {file} over monitor {i}");
                wallpaper.SetWallpaper(wallpaper.GetMonitorDevicePathAt(i), String.Format(file, (i + 1)));
                wallpaper.SetPosition(DesktopWallpaperPosition.Fill);
            }

             return $"Load sqn img  {monitorTotal.ToString()} over monitor {String.Format(file, (monitorTotal + 1))}" ; 

        }

        public bool StartsWithUpper(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char.IsUpper(ch);
        }

        /// <summary>
        /// Add Function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Substract Function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Substract(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiply Function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Divide Function
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}