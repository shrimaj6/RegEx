﻿using System;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Regular Expression Program \n");
            Console.WriteLine("Write your Password ex : Aa9 length atleast 8 .");
            Console.Write("\n Enter Password : ");
            string name = Console.ReadLine();
            Pattern.Password(name);
        }
    }
}
