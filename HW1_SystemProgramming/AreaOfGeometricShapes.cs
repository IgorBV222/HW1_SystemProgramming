using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AreaOfGeometricShapes
{
    public class MyAreaOfGeometricShapes
    {
        public static double MySquareArea(double a)
        {
            double area = Math.Pow(a, 2);
            return area;
        }
        public static double MySquareArea(string str)
        {
            double area = Math.Pow(Convert.ToDouble(str), 2);
            return area;
        }

        public static decimal MySquareRectangle(decimal a, decimal b)
        {
            decimal rectangle = a * b;
            return rectangle;
        }
        public static decimal MySquareRectangle(string str)
        {
            decimal rectangle = 1;
            string[] num = str.Split(';');
            foreach (string s in num)
            {
                rectangle *= Convert.ToDecimal(s);
            }              
            return rectangle;
        }
        public static decimal MySquareTriangle(decimal a, decimal h)
        {
            decimal triangle = (a * h) / 2;
            return triangle;
        }
        public static decimal MySquareTriangle(string str)
        {
            decimal triangle = 1;
            string[] num = str.Split(';');
            foreach (string s in num)
            {
                triangle *= Convert.ToDecimal(s);
            }
            return triangle / 2;            
           
        }
    }
}
