using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SharedCalculatorGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new SharedCalculator.Calculator();

            Console.WriteLine("Skriv første tal");
            string input1 = Console.ReadLine();
            Console.WriteLine("Angiv operator");
            string opr = Console.ReadLine();
            Console.WriteLine("Skriv andet tal");
            string input2 = Console.ReadLine();


        }
    }
}
