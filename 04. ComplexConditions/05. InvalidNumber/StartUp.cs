﻿using System;

public class StartUp
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        if (number >= 100 && number <= 200 || number == 0)
        {
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("invalid");
        }
    }
}