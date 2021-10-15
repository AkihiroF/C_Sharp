
using System;
using System.Collections.Generic;
class Programm
{
    static void Main()
    {
        int N;
        do
        {
            Console.Write("Введите размерностьмассива (меньше 15) = ");
            N = int.Parse(Console.ReadLine());
        } while (N >= 15);

        int[] A = new int[N];

        Console.WriteLine("\n\tИсходный массив\n");
        Random rnd = new Random(DateTime.Now.Millisecond);
        for (int i = 0; i < N; i++)
        {
            A[i] = rnd.Next(-90, -10);
            Console.Write(A[i] + " ");
        }

        Console.WriteLine("\n\n\tПреобразованный массив\n");

        int first = A[0];
        int second = A[1];
        int third = A[2];
        for (int i = 0; i < N-3; i++)
        {
            A[i] = A[i+3];
        }
        A[N-1] = third;
        A[N-2] = second;
        A[N-3] = first;

        foreach (int i in A)
        {
            Console.Write($" {i} ");
        }

        Console.Read();
    }
}//это всё я делал, честно