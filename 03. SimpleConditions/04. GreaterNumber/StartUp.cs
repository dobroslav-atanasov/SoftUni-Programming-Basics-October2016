﻿using System;

public class StartUp
{
    public static void Main()
    {
        var num1 = int.Parse(Console.ReadLine());
        var num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine(num1);
        }
        else
        {
            Console.WriteLine(num2);
        }
    }
}