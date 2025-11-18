using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Most.Basic.Calculator.Ever
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            double r=0;


            Console.Write("enter the first digit: ");
            double a=Convert.ToDouble(Console.ReadLine());

            Console.Write("enter the operation: ");
            string c=Console.ReadLine();

            Console.Write("enter the second digit: ");
            double b = Convert.ToDouble(Console.ReadLine());


            switch (c){

                case "+": r=  a + b; Console.WriteLine(a + "+" + b + "=" + r); break;
                case "-": r = a - b; Console.WriteLine(a + "-" + b + "=" + r); break;
                case "*": r = a * b; Console.WriteLine(a + "*" + b + "=" + r); break;
                case "/": r = a / b; Console.WriteLine(a + "/" + b + "=" + r); break;
                default:  Console.WriteLine("something went wrong");
              }

            






        }
    }
}

