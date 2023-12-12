using System;
using System.IO;

namespace FileProgramEx
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            string pathName = @"C:\Users\whizt\Desktop\Rahul Kondi\C# File Examples\Sample.txt";
            string pathName2 = @"C:\Users\whizt\Desktop\Rahul Kondi\C# File Examples\Sample2.txt";
            #region  Create a File
            //FileStream fs = File.Create(pathName);
            //if (File.Exists(pathName))
            //{
            //    Console.WriteLine("File is created.");
            //}
            //else
            //{
            //    Console.WriteLine("File is not created.");
            //}
            #endregion
            #region Open File
            //FileStream f = File.Open(pathName, FileMode.Open);
            #endregion
            #region Write to a File
            //File.WriteAllText(pathName, "Kondi Rahul");
            #endregion
            #region Read a File 
            //string readText = File.ReadAllText(pathName);
            //Console.WriteLine(readText);
            #endregion
            #region Replaceing the one file content to onther File
            File.Copy(pathName, pathName2);
            Console.WriteLine(File.ReadAllText(pathName2));
            #endregion
            Console.ReadKey();
        }
    }
}
