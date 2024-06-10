using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GanBuilder
{
    public static class Theme
    {
        public enum Languages { English, Spanish, French }
        public static Languages language = Languages.English;
        public enum Themes {Dark, Light}
        public static Themes theme = Themes.Light;
        public static Color text;
        public static Color textButton;
        public static Color titles;
        public static Color background;
        public static Color highlight;
        public static Color sidebar;
        public static Color inside;
        public static Color sidebar_selected;
        public static Color trainer;
        public static Color artist;
        public static Color settings;
        public static Color about;
        public static Color gray;

        public static void getTheme()
        {
            if(theme == Themes.Light)
            {
                text = Color.Black;
                titles = Color.White;
                textButton = Color.AliceBlue;
                background = Color.FromArgb(230, 230, 230);
                highlight = Color.MediumSlateBlue;
                sidebar = Color.FromArgb(26, 33, 43);
                sidebar_selected = Color.FromArgb(40, 51, 66);
                inside = Color.LightGray;
                trainer = Color.DodgerBlue;
                artist = Color.FromArgb(249, 118, 176);
                settings = Color.FromArgb(253, 138, 114);
                about = Color.MediumSlateBlue;
                gray = Color.SlateGray;
            }

            else
            {
                text = Color.AliceBlue;
                textButton = Color.AliceBlue;
                titles = Color.White;
                background = Color.FromArgb(23, 33, 68);
                highlight = Color.MediumSlateBlue;
                sidebar = Color.FromArgb(16, 23, 39);
                inside = Color.FromArgb(16, 23, 39);
                sidebar_selected = Color.FromArgb(37, 36, 81);
                trainer = Color.DodgerBlue;
                artist = Color.FromArgb(249, 118, 176);
                settings = Color.FromArgb(253, 138, 114);
                about = Color.MediumSlateBlue;
                gray = Color.SlateGray;

            }

        }

        public static void getLanguage(Thread thread)
        {
            if (language == Languages.Spanish)
            {
                thread.CurrentUICulture = new System.Globalization.CultureInfo("es");
            }
            else if (language == Languages.French)
            {
                thread.CurrentUICulture = new System.Globalization.CultureInfo("fr");
            }
            else
            {
                thread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            }
        }


    }
}
