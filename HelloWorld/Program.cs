﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo userAction = Console.ReadKey(true);
            bool exit = false;
            Message unMessage = new Message();
            while (!exit)
            {
                Console.WriteLine(unMessage.HelloMessage);
                string input = Console.ReadLine();
                exit = input == "exit";
            }
        }
    }
}

