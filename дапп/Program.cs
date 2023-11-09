using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace дапп
{
    internal class Program
    {
       
        //1 длина стороны
        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        //Периметр
        static void P(double AB, double BC, double AC)
        {
            if (AC < BC + AB && BC < AB + AC && AB < BC + AC)
            {
                double P = AB + BC + AC;    
                WriteLine($"Периметр треугольника: {P:f2}");
            }
            else
            {
                WriteLine("такой треугольнмик не существует.");
            }
        }
        //Площадь
        static void S(double AB, double BC, double AC)
        {
            double sP = (AB+BC+AC)/ 2;
            double S = Math.Sqrt(sP * (sP - AB) * (sP - BC) * (sP - AC));
            WriteLine($"Площадь треугольника: {S:f2}");
        }
        static void Main(string[] args)
        {
            Write($"Введите координаты точки A:\nx1 = ");
            int x1 = Convert.ToInt32(ReadLine());
            Write("y1 = ");
            int y1 = Convert.ToInt32(ReadLine());
            Write($"Введите координаты точки B:\nx2 = ");
            int x2 = Convert.ToInt32(ReadLine());
            Write("y2 = ");
            int y2 = Convert.ToInt32(ReadLine());
            Write($"Введите координаты точки C:\nx3 = ");
            int x3 = Convert.ToInt32(ReadLine());
            Write("y3 = ");
            int y3 = Convert.ToInt32(ReadLine());
            double AB = Distance(x1, y1, x2, y2);
            double BC = Distance(x2, y2, x3, y3);
            double AC = Distance(x3, y3, x1, y1);
            WriteLine($"Длина стороны AB: {AB:f2} ");
            WriteLine($"Длина стороны BC: {BC:f2} ");
            WriteLine($"Длина стороны CA: {AC:f2} ");
            P(AB,BC,AC);
            S(AB,BC,AC);
            
            ReadKey();
        }
    }
}
