using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace P_Analisis
{
    class Control
    {
        private Imagen meta;
        private Imagen current;
        private int cantidadG;
        private int cont;
        private Imagen[] generaciones;
        private int height;
        private int width;
        
        public Control()
        {
            meta = new Imagen();
            current = new Imagen();
        }

        public void empezar(String me,int cant)
        {

            cantidadG = cant;
            generaciones = new Imagen[cant];
            meta.setImagen(me);
            height = meta.getImagen().Height;
            width = meta.getImagen().Width;
            Bitmap bmp = new Bitmap(width, height);
            Random rand = new Random();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //generate random ARGB value
                    int a = rand.Next(256);
                    int r = rand.Next(256);
                    int g = rand.Next(256);
                    int b = rand.Next(256);

                    //set ARGB value
                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }

            current.setImagen(bmp);
            generaciones[cont] = current;
            

        }
        
        public void nextGen()
        { 
        }
    }
}
