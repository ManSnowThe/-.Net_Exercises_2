﻿using System;

namespace Newton_s_method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Newton nt = new Newton(7, 3);
            Newton nt;

            Console.WriteLine(@"Данное приложение извлекает корень n-степени методом Ньютона" +
                "\nВведите число и степень корня: ");

            double number = Convert.ToDouble(Console.ReadLine());
            double power = Convert.ToDouble(Console.ReadLine());

            nt = new Newton(number, power);

            Console.WriteLine($"Результат методом Ньютона: {nt}");
            Console.WriteLine("Результат методом Math.Pow: " + Math.Pow(number, 1.0/power));
            Console.ReadLine();
        }
    }

    class Newton
    {
        readonly double min = 0.000001;
        double _num;
        double _n;

        public Newton(double num, double n)
        {
            Number = num;
            Power = n;
            Sqrt(Number, Power);
        }

        public double Number
        {
            get
            {
                return _num;
            }
            set
            {
                _num = value;
            }
        }

        public double Power
        {
            get
            {
                return _n;
            }
            set
            {
                _n = value;
            }
        }

        double temp;
        double result;

        public double Sqrt(double num, double n)
        {
            temp = num / n;
            result = n;

            while (Math.Abs(result - temp) >= min)
            {
                temp = result;
                result = (1 / n) * ((n - 1) * temp + num / Math.Pow(temp, n - 1));
            }
            return result;
        }

        public override string ToString()
        {
            return $"{result}";
        }
    }
}
