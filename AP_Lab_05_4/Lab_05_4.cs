// Lab_05_4.cs
// Якубовський Владислав
// Лабораторна робота № 5.4 
// Обчислення сум та добутків за допомогою рекурсії.
// Варіант 24
using System;
using static System.Math;

namespace AP_Lab_05_4
{
    public class Lab_05_4
    {
        public static double ZeroSum(int N)
        {
            double sum = 0;

            for(int ii = 1; ii <= N; ii++)
                sum += Sqrt(1 + Pow(Cos(Sin(ii)), 2)) / (1 + Pow(Sin(Cos(ii)), 2));

            return sum;
        }

        static double FirstSum(int N, int ii)
        {
            if (ii > N)
                return 0;

            else return Sqrt(1 + Pow(Cos(Sin(ii)), 2)) / (1 + Pow(Sin(Cos(ii)), 2)) + FirstSum(N, ii + 1);
        }
    
        static double SecondSum(int N, int ii)
        {
            if (ii < 1)
                return 0;

            else return Sqrt(1 + Pow(Cos(Sin(ii)), 2)) / (1 + Pow(Sin(Cos(ii)), 2)) + SecondSum(N, ii - 1);
        }

        static double ThirdSum(int N, int ii, double t)
        {
            t += Sqrt(1 + Pow(Cos(Sin(ii)), 2)) / (1 + Pow(Sin(Cos(ii)), 2));

            if (ii >= N)
                return t;

            else return ThirdSum(N, ii + 1, t);
        }

        static double FourthSum(int N, int ii, double t)
        {
            t += Sqrt(1 + Pow(Cos(Sin(ii)), 2)) / (1 + Pow(Sin(Cos(ii)), 2));

            if (ii <= 1)
                return t;

            else return FourthSum(N, ii - 1, t);
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.Write("Введіть значення змінної \"N\": ");

            int N = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nОтримане нульовим способом значення:\t{ZeroSum(N)}\n" +
                $"Отримане першим способом значення:\t{FirstSum(N, 1)}\n" +
                $"Отримане другим способом значення:\t{SecondSum(N, N)}\n" +
                $"Отримане третім способом значення:\t{ThirdSum(N, 1, 0)}\n" +
                $"Отримане четвертим способом значення:\t{FourthSum(N, N, 0)}\n");

            Console.ReadLine();
        }
    }
}