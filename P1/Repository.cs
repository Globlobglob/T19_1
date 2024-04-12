using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class Repository
    {
        List<Imain>figures = new List<Imain>();

        public void TrianglePrint()
        {
            Console.Clear();
            figures.Add(Triangle.TrianglePrint());
        }

        public void RectanglePrint()
        {
            Console.Clear();
            figures.Add(Rectangle.RectanglePrint());
        }

        public void  CirclePrint()
        {
            Console.Clear();
            figures.Add(Circle.PrintCircle());
        }

        public void GetAll()
        {
            foreach (Imain fig in figures)
            {
                Console.WriteLine(fig.ToString());
            }
        }

       
    }
}
