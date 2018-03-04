using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P_Analisis
{
    class Program
    {
        static void Main(string[] args)
        {
            Control p = new Control();
            p.empezar(@"C:\Users\vicnb\Desktop\metaimagen.png",80);
            
            Console.ReadKey();
        }
    }
}