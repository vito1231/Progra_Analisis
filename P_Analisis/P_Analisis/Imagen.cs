using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace P_Analisis
{
    class Imagen
    {
        private Bitmap imagen;
        private int[] histRojo;
        private int[] histVerde;
        private int[] histAzul;

        public Imagen()
        {
            histAzul = new int[256];
            histRojo = new int[256];
            histVerde = new int[256];

        }
        public void setImagen(Bitmap img)
        {
            imagen = img;
        }

        public void setImagen(String dir)
        {
            
            imagen = new Bitmap(dir);
            

        }
        public Bitmap getImagen()
        {
            return imagen;
        }

        public int[] getHistRojo()
        {
            return histRojo;
        }

        public int[] getHistAzul()
        {
            return histAzul;
        }

        public int[] getHistVerde()
        {
            return histVerde;
        }

        public void generateHistograms()
        {
            for(int i = 0; i < imagen.Width; i++)
            {
                for(int j = 0; j < imagen.Height; j++)
                {
                    Color color = imagen.GetPixel(i,j);
                    histAzul[color.B]++;
                    histRojo[color.R]++;
                    histVerde[color.G]++;  
                }
            }
        }
    }
}
