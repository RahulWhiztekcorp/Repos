using System;
using System.Linq;

namespace UserDefinedExceptionHandlingProgramsEX
{
    public class invalidphonenumberException : Exception
    {
        public invalidphonenumberException()
        {
        }
        public invalidphonenumberException(string message)
            : base(message)
        {
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string phonenumber = "0123456789";
                IsValidPhoneNumber(phonenumber);
                Console.WriteLine(phonenumber);
            }
            catch (invalidphonenumberException e)
            {
                Console.WriteLine(e.Message);
            }
            finally {
                Console.ReadLine(); 
            }
        }

        public static void IsValidPhoneNumber(string phonenumber)
        {
            int length = phonenumber.Length;
            if (length < 10)
            {
                throw new invalidphonenumberException("Phone number Length minimum length is 10 || You Entered Length is : " + length);
            }
            if (length > 10)
            {
                throw new invalidphonenumberException("Phone number Length maximum length is 12 || You Entered Length is : " + length);
            }
        }
    }
}
