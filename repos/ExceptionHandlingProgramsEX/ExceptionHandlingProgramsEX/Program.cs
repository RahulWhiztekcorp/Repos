using System;

namespace ExceptionHandlingProgramsEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------- ExceptionHandlingProgramsEX ----------------");
            Console.WriteLine("--------------------------------------------------------------");
            //    int a = 10;
            //    int b = 0;
            //    int x = a / b;
            //    Console.WriteLine("Rest of the code");
            //    Unhandled Exception: System.DivideByZeroException: Attempted to divide by zero.
            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;
            }
            catch (Exception e){
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("Finally block is executed");
            }
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Rest of the code");
        }
    }
}
