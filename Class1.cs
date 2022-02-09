using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lesson
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] num = new int[5];
            int a=0;
            int k=0;
            do
            {
                try
                {
                    Console.WriteLine("Введи число");
                    a = int.Parse(Console.ReadLine());

                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp);
                }
                num[k] = a;
                k++;
            } while (k < 5);
            int summa = 0;
            int korr = 1;
            double arif = 0;
            foreach (int arv in num)
            {
                summa += arv;
                korr *= arv;
                arif += arv / num.Length;
            }
            Console.WriteLine($"Summa: {summa}, Korr: {korr}, Arif: {arif}");



            //Random rnd = new Random();
            //int m = rnd.Next(1, 100);
            //int n = rnd.Next(1, 100);
            //Console.WriteLine($"N={n}");
            //Console.WriteLine($"M={m}");
            //if (n > m)
            //{
            //    int abi = n;
            //    n = m;
            //    m = abi;
            //}
            //int[] mass = new int[m - n + 1];
            //int j = 0;
            //for (int i = n; i < m+1; i++)
            //{
            //    mass[j]= i;
            //    j++;
            //}
            //foreach (int Mass in mass)
            //{
            //    Console.WriteLine($"{Mass*Mass,5}");
            //}
            //Console.WriteLine();




















            //char[] Letter = new char[7] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            //Console.WriteLine($"First letter is {Letter[0]}");

            //foreach (char letter in Letter)
            //{
            //    Console.Write($"{letter,2}");
            //}
            //Random rnd = new Random();
            //int[] number = new int[10];
            //for (int i = 0; i < number.Length; i++)
            //{
            //    number[i] = rnd.Next(5, 500);
            //}
            //foreach (int num in number)
            //{
            //    Console.Write($"{num,4}");
            //}
            //Console.WriteLine();
            //int[,] Kino = new int[20, 10];
            //for (int i = 0; i < 20; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine($" line {i} place {j}");
            //    }
            //    Console.WriteLine();
            //}




            Console.ReadLine();

        }   
    }
}
