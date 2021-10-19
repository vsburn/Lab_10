using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение угла: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение минут угла: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение секунд угла: ");
            int s = Convert.ToInt32(Console.ReadLine());
            Angle ang = new Angle(g, m, s);
            Console.WriteLine($"{ang.Gradus}° {ang.Minute}\' {ang.Second}\"");
            ang.ToRadians();
            Console.ReadKey();
        }
    }
    class Angle
    {
        int grad;
        int min;
        int sec;
        public Angle(int gradus, int minute, int second)
        {
            Gradus = gradus;
            Minute = minute;
            Second = second;
        }
        public int Gradus
        {
            set
            {
                if (Math.Abs(value) >= 360)
                    grad = value % 360;
                else
                    grad = value;
                if (grad < 0)
                    grad += 360;
            }
            get
            {
                return grad;
            }
        }
        public int Minute
        {
            set
            {
                if ((value > 59) || (value < 0))
                    Console.WriteLine("Неверное значение для минут угла");
                else
                    min = value;
            }
            get
            {
                return min;
            }
        }
        public int Second
        {
            set
            {
                if ((value > 59) || (value < 0))
                    Console.WriteLine("Неверное значение для секунд угла");
                else
                    sec = value;
            }
            get
            {
                return sec;
            }
        }
        public void ToRadians()
        {
            Console.WriteLine((grad * Math.PI) / 180 + (min * Math.PI) / (180 * 60) + (sec * Math.PI) / (180 * 60 * 60) + " rad");
        }
    }
}
