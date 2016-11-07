using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assignment9
{
    public class SortedColor
    {
        static SortedDictionary<string, Color> colors = new SortedDictionary<string, Color>();

        public static Color Blue
        {
            get
            {
                return colors["Blue"];
            }
        }

        public static Color Red
        {
            get
            {
                return colors["Red"];
            }
        }

        public static Color Green
        {
            get
            {
                return colors["Green"];
            }
        }

        public static Color Black
        {
            get
            {
                return colors["Black"];
            }
        }

        public SortedColor()
        {
            colors.Add("Blue", Color.Blue);
            colors.Add("Red", Color.Red);
            colors.Add("Green", Color.Green);
            colors.Add("Black", Color.Black);
        }
    }
}
