﻿using System;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string('*', n));
        }
    }
}