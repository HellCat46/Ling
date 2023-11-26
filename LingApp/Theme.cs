using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LingApp
{
    struct Theme
    {
        public byte[] button, text, background;
    }

    internal class ThemeManager
    {
        public static Theme GetDefault()
        {
            return Dark();
        }
        private static Theme Light() // Catppuccin Latte
        {
            Theme theme = new Theme();
            theme.button = new byte[3] { 114, 135, 253 };
            theme.text = new byte[3] { 76, 79, 105 }; 
            theme.background = new byte[3] { 239,241,245 };

            return theme;
        }

        private static Theme Dark() // Catppuccin Mocha
        {

            Theme theme = new Theme();

            theme.button = new byte[3] { 180, 190, 254 };
            theme.text = new byte[3] { 205, 214, 244 };
            theme.background = new byte[3] { 30, 30, 46 };

            return theme;
        }
    }
}
