using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdv_windowsforms
{
    class ThemeColor
    {
        public static Color primaryColor { get; set; }
        public static Color secondaryColor { get; set; }

        public static List<string> colorList = new List<string>()
        {
            "#3F5185",
            "#009688",
            "#0D421D",
            "#906720",
            "#009688",
            "#FF5722",
            "#607D88",
            "#FF9800",
            "#9C27B0",
            "#2196F3",
            "#EA676C",
            "#E41A4A",
            "#EF937E",
            "#F37521",
            "#A12059",
            "#126881",
            "#009488",
            "#364D5B",
            "#0094BC",
            "#E4126B",
            "#43B76E",
            "#009688",
            "#A21D1D",
            "#5146A7",
            "#46A769",
            "#B71C46",
        };

        public static Color changeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //if correctio factor is less than 0, darken color
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }//
}
