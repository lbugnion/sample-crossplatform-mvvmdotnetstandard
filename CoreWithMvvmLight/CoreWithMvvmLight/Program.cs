using CoreWithMvvmLight.Model;
using GalaSoft.MvvmLight.Ioc;
using System;

namespace CoreWithMvvmLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press a key to initialize SimpleIoc");
            Console.WriteLine("Press 1 to use a test service");
            Console.WriteLine("Press 2 to use the real service");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SimpleIoc.Default.Register<IDataService, TestDataService>();
                    break;

                case "2":
                    SimpleIoc.Default.Register<IDataService, DataService>();
                    break;

                default:
                    Console.WriteLine("Invalid choice, bye");
                    return;
            }

            Console.WriteLine("Initialized, enter the first operand");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second operand");
            var num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please wait");

            var result = OtherProgram.Execute(num1, num2).Result;
            Console.WriteLine(result);
        }
    }
}
