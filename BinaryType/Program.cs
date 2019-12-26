using System;

namespace BinaryType
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryFormat bf = new BinaryFormat();
            
            Console.WriteLine("Введите десятичное число для перевода в двоичный вид: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Перевод в двоичный вид собственным алгоритмом: " + bf.IntToBin(number));

            Console.Write("Перевод в двоичный вид через Convert.ToString(value, 2): ");

            string binaryNumber = Convert.ToString(number, 2);
            Console.WriteLine(binaryNumber);

            Console.ReadLine();
        }
    }
    class BinaryFormat
    {
        readonly string[] binary = new string[32];
        int index = 0;

        public string IntToBin(int num)
        {
            int temp;
            while (num > 0)
            {
                temp = num % 2;
                num /= 2;
                binary[index++] = temp.ToString();
            }
            return Reverse(binary);
        }

        private string Reverse(string[] binar)
        {
            string[] result = new string[binar.Length];
            for (int i = binar.Length - 1; i >= 0; i--)
            {
                result[binar.Length - 1 - i] = binar[i];
            }
            return string.Join("", result);
        }
    }
}
