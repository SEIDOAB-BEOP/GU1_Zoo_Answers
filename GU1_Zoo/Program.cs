﻿using Helpers;
namespace GU1_Zoo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Zoo!");

        var n = new csZoo(5, "Small Zoo");
        Console.WriteLine(n);

        var n1 = new csZoo(25, "Large Zoo");
        Console.WriteLine(n1);

        var refZoo = new csZoo();
        Console.WriteLine(refZoo);
    }
}

