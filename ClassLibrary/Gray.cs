using PluginProject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Version(1, 0)]
    public class Gray : IPlugin
    {
        public string Name
        {
            get
            {
                return "Оттенки серого";
            }
        }

        public string Author
        {
            get
            {
                return "Me";
            }
        }

        public void Transform(Bitmap bitmap)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    int middle = (color.R + color.G + color.B) / 3;
                    Color newColor = Color.FromArgb(middle, middle, middle);
                    bitmap.SetPixel(i, j, newColor);
                }
            }
        }
    }
}
