using System;

namespace For
{
    class Program
    {
        public static void Main(string[] args)
        {
            For11();
        }
        static void For1()
        {                                                  
            //Я тут немножко залип, потому написал этот char ￣\(^_^)/￣
            Console.Write("Введи число: ");
            int K = int.Parse(Console.ReadLine());
            //char B = 'B';
            Console.WriteLine("Сколько раз будем выводить число?");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{K} ");
                System.Threading.Thread.Sleep(5);
            }
        }
        static void For2()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            for(int i = A; i <= B; i++)
            {
                Console.Write($"{i} ");
                System.Threading.Thread.Sleep(10);
            }

        }
        static void For3()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            for(int i = A + 1; i < B; i++)
            {
                Console.Write($"{i} ");
                System.Threading.Thread.Sleep(10);

            }
        }
        static void For4()
        {
            int costForOneKgSweet = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                int allCost = i * costForOneKgSweet;
                Console.WriteLine($"Cost for {i, 2} kg = {allCost, 4}UAH");
                System.Threading.Thread.Sleep(10);
            }

        }
        static void For5()
        {
            float costForOneKgSweet = float.Parse(Console.ReadLine());
            for(float i = 1; i <= 10; i++)
            {
                float allCost = (i / 10) * costForOneKgSweet;
                Console.WriteLine($"Cost for {i/10, 3} kg = {allCost, 5}UAH");
            }
        }
        static void For6()
        {
            double costForOneKgSweet = double.Parse(Console.ReadLine());
            for(double i = 1; i <= 5; i += 2)
            {
                double lol = 1.2;
                double allCost = (lol / i) * costForOneKgSweet;
                lol += 1.6;
                Console.WriteLine(lol);   
            }
        }
        static void For10()
        {
            double num = double.Parse(Console.ReadLine());
            double sum = 0;
            for (double n = 1; n <= num; n++)
            {
                sum += (1 / n);
            }
            Console.WriteLine(sum);

        }
        static void For10Extreme()
        {
            double num = double.Parse(Console.ReadLine());
            double sum = 1;
            double factorial = 1;
            for (double n = 1; n <= num; n++)
            {
                sum += (1 / (n * (n - 1)));
            }
            Console.WriteLine(sum);
            //return sum;
        }
        static void For11()
        {
            double N = double.Parse(Console.ReadLine());
            double newN = 0;
            for(double i = 0; i < N; i++)
            {
                newN = Math.Pow(N + i, 2);
            }
            Console.WriteLine(newN);
        }
        static void For12()
        {
            int N = int.Parse(Console.ReadLine());
            double p = 1;
            double a = 1.1;
            for (int i = 1; i <= N; ++i)
            {
                p *= a;
                a += 0.1;
            }
            Console.WriteLine(p);
        }
        static void For15()
        {
            Console.Write("Enter the number: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Enter the power: ");
            int n = int.Parse(Console.ReadLine());
 
 
            float rez = 1;
            
            for (int i = 1; i <= n; ++i) {
                rez *= a;
            }
            Console.WriteLine(rez);
        }
        static void For16()
        {
            float a = float.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            float rez = 1;
            
            for (int i = 1; i <= n; ++i)
            {
                rez *= a;
                Console.WriteLine(rez);
            }
        }
        static void For17()
        {
            float a = float.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());


            float a2 = 1, rez = 1;
            

            for (int i = 2; i <= n; ++i)
            {
                a2 *= a;
                rez += a2;
            }
            Console.WriteLine(rez);
        }
        static void For18()
        {
            float a = float.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());


            float a2 = 1, rez = 1;
            

            for (int i = 2; i <= n; ++i)
            {
                a2 *= -a;
                rez += a2;
            }
            Console.WriteLine(rez);
        }
        static void For22()
        {
            float x = float.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());


            float x1 = 1, n1 = 1, rez = 1;
            

            for (int i = 1; i <= n; ++i)
            {
                n1 *= (float)i;
                x1 *= x;
                rez += x1 / n1;
            }
            Console.WriteLine(rez);
        }
    }
}
