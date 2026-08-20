using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> L1 = new List<int> { 5, 2, 8, 1 };
        List<int> L2 = new List<int> { 7, 3, 9, 4 };
        List<int> L3 = new List<int>();
        L3.AddRange(L1);
        L3.AddRange(L2);
        L3.Sort();
        Console.WriteLine("L3 em ordem crescente:");
        foreach (int numero in L3)
        {
            Console.Write(numero + " ");
        }
        L3.Reverse();
        Console.WriteLine("\n\nL3 em ordem decrescente:");
        foreach (int numero in L3)
        {
            Console.Write(numero + " ");
        }
    }
}