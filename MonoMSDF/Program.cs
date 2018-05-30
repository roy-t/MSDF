using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FontAnalyzer.TTF;
using FontAnalyzer.TTF.Cmap;

namespace MonoMSDF
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var fonts = new List<TrueTypeFont>();
            var formats = new Dictionary<CMapSubtableFormat, int>();
            
            foreach (var f in Enum.GetValues(typeof(CMapSubtableFormat)).OfType<CMapSubtableFormat>())
            {
                formats.Add(f, 0);
            }

            foreach (var file in Directory.EnumerateFiles(@"C:\Windows\Fonts").Select(f => f.ToLower()))
            {
                if (file.EndsWith(".ttf"))
                {
                    var ttf = TrueTypeFont.FromFile(file);

                    foreach (var f in ttf.CmapTable.EncodingRecords)
                    {                        
                        formats[f.Format] += 1;
                    }

                    fonts.Add(ttf);
                }
            }


            using (var game = new Game1())
                game.Run();
        }
    }
#endif
}
