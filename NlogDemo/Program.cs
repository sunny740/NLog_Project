using System;
using NLog;
using NlogDemo;

namespace NLogDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To NLog!");
            AddNumber add = new AddNumber();
            add.Sum(1, 2);

        }
    }
}