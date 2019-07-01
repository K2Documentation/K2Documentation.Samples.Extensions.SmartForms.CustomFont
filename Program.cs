using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SourceCode.Forms.Management;
using SourceCode.Hosting.Client.BaseAPI;

namespace K2Documentation.Samples.Extensions.SmartForms.CustomFont
{
    public class CustomFontsExamples
    {
        public static void Main(string[] args)
        {
            //CreateFontExample();
            //UpdateFontExample();
            //DeleteFontExample();
        }

        public static void CreateFontExample()
        {
            //Create a new font instance
            Font font = new Font()
            {
                Name = "MyCorporateFont",
                FontFamily = "wingdings",
            };

            // Open connection to host server
            FormsManager manager = new FormsManager("localhost", 5555);

            // Save new font instance
            manager.SetFont(font);
        }

        public static void UpdateFontExample()
        {
            // Open connection to host server
            FormsManager manager = new FormsManager("localhost", 5555);

            // Get existing fonts explorer
            FontExplorer fonts = manager.GetFonts();

            // Get specific font instance
            Font font = fonts.Fonts["MyCorporateFont"];

            // Update font instance
            font.Name = "My Corporate Font";
            font.FontFamily = "arial";

            // Save modified font
            manager.SetFont(font);
        }

        public static void DeleteFontExample()
        {
            // Open connection to host server
            FormsManager manager = new FormsManager("localhost", 5555);

            // Delete font by name
            manager.DeleteFont("MyCorporateFont");
        }
    }
}
