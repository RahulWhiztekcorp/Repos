using System;
using System.Text;
using System.Collections.Generic; 

namespace CsharpPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            //p.AssignmentOperatorEx();
            //p.ArithmeticOperatorsEx();
            //p.RelationalOperatorsEx();
            //p.LogicalOperatorsEx();
            //p.UnaryOperatorsEx();
            //p.TernaryOperatorEx();
            //p.BitwiseandBitShiftOperatorsEx();
            //p.CompoundAssignmentOperatorsEx();
            //p.ControlstatementsEx();
            //p.BoxingAndUnboxingEx();
            //p.TypeCasteingEx();
            //p.LoopsEX();
            //p.Looppatterns();
            //p.UnconditionaljumpstatementsEx();
            //p.PredefinedFunctionEx();
            //p.UserdefinedFunctionEx();
            //p.StringBuilderEx();
            //p.Arrays();
            //p.List();
            //p.Prime();

            //SingleINHChild s = new SingleINHChild();
            //Console.WriteLine("Single Inhertance : " +s.Name);
            //Console.WriteLine("------------------------------------------");
            //MultilevelINHChild ml = new MultilevelINHChild();   
            //Console.WriteLine("MultiLevel Inhertance GrandParent : " + ml.Name);
            //Console.WriteLine("MultiLevel Inhertance Parent : " + ml.Name1);
            //Console.WriteLine("MultiLevel Inhertance Child : " + ml.Name2);
            //Console.WriteLine("------------------------------------------");
            //HierarchicalINHChild1 hc1 = new HierarchicalINHChild1();
            //Console.WriteLine("Hierarchical Inhertance Child1 : " + ml.Name);
            //HierarchicalINHChild2 hc2 = new HierarchicalINHChild2();
            //Console.WriteLine("Hierarchical Inhertance Child2 : " + ml.Name);
            //Console.WriteLine("------------------------------------------");
            //HybridMultilevelINHChild1 hyc1 = new HybridMultilevelINHChild1();
            //Console.WriteLine("Hierarchical Inhertance Child1 Grandparent Data : " + ml.Name);
            //HybridMultilevelINHChild2 hyc2 = new HybridMultilevelINHChild2();
            //Console.WriteLine("Hierarchical Inhertance Child2 Grandparent Data : " + ml.Name);

            //List<string> list = new List<string>() { "Rahul", "Ravi", "Raju", "Jake", "Kamal" };
            //var names = new string[] { "Mahesh", "Venky", "Prasad", };
            //list.First();
            //Console.WriteLine("list.First() "+list.First());
            //list.FirstOrDefault();
            //Console.WriteLine("list.FirstOrDefault() " + list.FirstOrDefault());
            //list.Last();
            //Console.WriteLine("list.First() " + list.Last());
            //list.LastOrDefault();
            //Console.WriteLine("list.FirstOrDefault() " + list.LastOrDefault());
            //Console.WriteLine("---------------------------------------------");
            //list.ForEach(x => Console.WriteLine(x));
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("---------Insert() and InsertRange()----------");
            //list.Insert(1,"Siri");
            //list.InsertRange(9, names);
            //list.ForEach(x => Console.WriteLine(x));
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("-------------------Sort()--------------------");
            //list.Sort();
            //list.ForEach(x => Console.WriteLine(x));
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("-------------------Reverse()-----------------");
            //list.Reverse();
            //list.ForEach(x => Console.WriteLine(x));
            //HashSet<string> set = new HashSet<string>() { "Rahul", "Ravi", "Raju", "Jake", "Kamal" };



            //Average,element At, intercet, join, Prepend
            //------------------------------ Average -----------------------------//
            //    int[] intNumbers = new int[] { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };
            //    //Using Method Syntax
            //    var MSAverageValue = intNumbers.Average();
            //    //Using Query Syntax
            //    var QSAverageValue = (from num in intNumbers
            //                          select num).Average();
            //    Console.WriteLine("List Average Value(Using Method) = " + MSAverageValue);
            //    Console.WriteLine("List Average Value(Using Query) = " + QSAverageValue);
            //    //***********************************************************************//
            //    SortedSet<int> setnum = new SortedSet<int>();
            //    setnum.Add(101);
            //    setnum.Add(1001);
            //    setnum.Add(10001);
            //    setnum.Add(100001);
            //    var data = setnum.Average();
            //    Console.WriteLine("SortedSet Average Value = " + data);
            //    //**********************************************************************//
            //    HashSet<int> hashstr = new HashSet<int>() { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };
            //    var datah = hashstr.Average();
            //    Console.WriteLine("HashSet Average Value = " + datah);
            ////----------------------------- ElementAt ------------------------------//
            //    List<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            //    List<string> strList = new List<string>() { "One", "Two", "There","Four", "Five" };

            //    Console.WriteLine("1st Element in intList: {0}", intList.ElementAt(0));
            //    Console.WriteLine("1st Element in intList: {0}", strList.ElementAt(0));
            //    //***********************************************************************//
            //    SortedSet<int> setnume = new SortedSet<int>();
            //    setnum.Add(101);
            //    setnum.Add(1001);
            //    setnum.Add(10001);
            //    setnum.Add(100001);
            //    Console.WriteLine("1st Element in intList: {0}", setnume.ElementAt(0));
            //    Console.WriteLine("1st Element in intList: {0}", setnume.ElementAt(0));
            //    //**********************************************************************//
            //    HashSet<int> hashstre = new HashSet<int>() { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };
            //    Console.WriteLine("1st Element in intList: {0}", hashstre.ElementAt(0));
            //    Console.WriteLine("1st Element in intList: {0}", hashstre.ElementAt(0));
            ////------------------------------ Intersect -----------------------------//
            //List<int> data1 = new List<int>() {10, 20, 30, 40, 50, 60, 70 };
            //List<int> data2 = new List<int>() {50, 60, 70, 80, 90, 100 };

            //var final = data1.Intersect(data2);

            //Console.WriteLine("Final Result is: ");
            //foreach (var j in final)
            //{
            //    Console.WriteLine("{0}",j);
            //}
            ////----------------------------- Join ------------------------------//
            //List<Employee> emp = new List<Employee>()
            //{
            //    new Employee { ID = 1, Name = "Preety", AddressId = 1 },
            //    new Employee { ID = 2, Name = "Priyanka", AddressId = 2 },
            //    new Employee { ID = 3, Name = "Anurag", AddressId = 3 },
            //    new Employee { ID = 4, Name = "Pranaya", AddressId = 4 },
            //    new Employee { ID = 5, Name = "Hina", AddressId = 5 },
            //    new Employee { ID = 6, Name = "Sambit", AddressId = 6 },
            //    new Employee { ID = 7, Name = "Happy", AddressId = 7},
            //    new Employee { ID = 8, Name = "Tarun", AddressId = 8 },
            //    new Employee { ID = 9, Name = "Santosh", AddressId = 9 },
            //    new Employee { ID = 10, Name = "Raja", AddressId = 10},
            //    new Employee { ID = 11, Name = "Sudhanshu", AddressId = 11}
            //};
            //List<Address> address = new List<Address>()
            //{
            //    new Address { ID = 1, AddressLine = "AddressLine1"},
            //    new Address { ID = 2, AddressLine = "AddressLine2"},
            //    new Address { ID = 3, AddressLine = "AddressLine3"},
            //    new Address { ID = 4, AddressLine = "AddressLine4"},
            //    new Address { ID = 5, AddressLine = "AddressLine5"},
            //    new Address { ID = 9, AddressLine = "AddressLine9"},
            //    new Address { ID = 10, AddressLine = "AddressLine10"},
            //    new Address { ID = 11, AddressLine = "AddressLine11"},
            //};
            //var JoinUsingMS = emp .Join( 
            //address,
            //employee => employee.AddressId,
            //address => address.ID,
            //(employee, address) => new 
            //{
            //    EmployeeName = employee.Name,
            //    AddressLine = address.AddressLine
            //}).ToList();

            ////Accessing the Result using For Each Loop
            //foreach (var employee in JoinUsingMS)
            //{
            //    Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            //}
            ////------------------------------ Prepend -----------------------------//
            //emp.Prepend(new Employee { ID = 0, Name = "Test", AddressId = 0 });
            //address.Prepend(new Address { ID = 0, AddressLine = "Test" });
            //var PrependJoin = emp.Join(
            //address,
            //employee => employee.AddressId,
            //address => address.ID,
            //(employee, address) => new
            //{
            //    EmployeeName = employee.Name,
            //    AddressLine = address.AddressLine
            //}).ToList();
            //foreach (var employee in PrependJoin)
            //{
            //    Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            //}

            BaseClass baseClass = new BaseClass();
            baseClass.Name = "Base class name";
            Console.WriteLine(baseClass.Name);

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Name = "Derived class name";
            Console.WriteLine(derivedClass.Name);


        }
        public void AssignmentOperatorEx()
        {
            Console.WriteLine("Assignment Operator Examples");
            int firstNumber, secondNumber;
            // Assigning a constant to variable
            firstNumber = 10;
            Console.WriteLine("First Number = {0}", firstNumber);

            // Assigning a variable to another variable
            secondNumber = firstNumber;
            Console.WriteLine("Second Number = {0}", secondNumber);
            Console.WriteLine("----------------------------------");
        }
        public void ArithmeticOperatorsEx()
        {
            Console.WriteLine("Arithmetic Operators Examples");

            double firstNumber = 14.40, secondNumber = 4.60, result;
            int num1 = 26, num2 = 4, rem;

            // Addition operator
            result = firstNumber + secondNumber;
            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);

            // Subtraction operator
            result = firstNumber - secondNumber;
            Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);

            // Multiplication operator
            result = firstNumber * secondNumber;
            Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);

            // Division operator
            result = firstNumber / secondNumber;
            Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);

            // Modulo operator
            rem = num1 % num2;
            Console.WriteLine("{0} % {1} = {2}", num1, num2, rem);
            Console.WriteLine("----------------------------------");

        }
        public void RelationalOperatorsEx()
        {
            Console.WriteLine("Relational Operators Examples");
            bool result;
            int firstNumber = 10, secondNumber = 20;

            result = (firstNumber == secondNumber);
            Console.WriteLine("{0} == {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber > secondNumber);
            Console.WriteLine("{0} > {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber < secondNumber);
            Console.WriteLine("{0} < {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber >= secondNumber);
            Console.WriteLine("{0} >= {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber <= secondNumber);
            Console.WriteLine("{0} <= {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber != secondNumber);
            Console.WriteLine("{0} != {1} returns {2}", firstNumber, secondNumber, result);
            Console.WriteLine("----------------------------------");
        }
        public void LogicalOperatorsEx()
        {
            Console.WriteLine("Logical Operators Examples");

            bool result;
            int firstNumber = 10, secondNumber = 20;

            // OR operator
            result = (firstNumber == secondNumber) || (firstNumber > 5);
            Console.WriteLine(result);

            // AND operator
            result = (firstNumber == secondNumber) && (firstNumber > 5);
            Console.WriteLine("----------------------------------");
            Console.WriteLine(result);
        }
        public void UnaryOperatorsEx()
        {
            Console.WriteLine("Unary Operators Examples");

            int number = 10, result;
            bool flag = true;

            result = +number;
            Console.WriteLine("+number = " + result);

            result = -number;
            Console.WriteLine("-number = " + result);

            result = ++number;
            Console.WriteLine("++number = " + result);

            result = --number;
            Console.WriteLine("--number = " + result);

            Console.WriteLine("!flag = " + (!flag));
            Console.WriteLine("----------------------------------");

        }
        public void TernaryOperatorEx()
        {
            Console.WriteLine("Ternary Operators Examples");

            int number = 10;
            string result;

            result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine("{0} is {1}", number, result);
            Console.WriteLine("----------------------------------");
        }
        public void BitwiseandBitShiftOperatorsEx()
        {
            Console.WriteLine("BitwiseandBitShift Operators Examples");

            int firstNumber = 10;
            int secondNumber = 20;
            int result;

            result = ~firstNumber;
            Console.WriteLine("~{0} = {1}", firstNumber, result);

            result = firstNumber & secondNumber;
            Console.WriteLine("{0} & {1} = {2}", firstNumber, secondNumber, result);

            result = firstNumber | secondNumber;
            Console.WriteLine("{0} | {1} = {2}", firstNumber, secondNumber, result);

            result = firstNumber ^ secondNumber;
            Console.WriteLine("{0} ^ {1} = {2}", firstNumber, secondNumber, result);

            result = firstNumber << 2;
            Console.WriteLine("{0} << 2 = {1}", firstNumber, result);

            result = firstNumber >> 2;
            Console.WriteLine("{0} >> 2 = {1}", firstNumber, result);
            Console.WriteLine("----------------------------------");

        }
        public void CompoundAssignmentOperatorsEx()
        {
            Console.WriteLine("CompoundAssignment Operators Examples");
            int number = 10;

            number += 5;
            Console.WriteLine(number);

            number -= 3;
            Console.WriteLine(number);

            number *= 2;
            Console.WriteLine(number);

            number /= 3;
            Console.WriteLine(number);

            number %= 3;
            Console.WriteLine(number);

            number &= 10;
            Console.WriteLine(number);

            number |= 14;
            Console.WriteLine(number);

            number ^= 12;
            Console.WriteLine(number);

            number <<= 2;
            Console.WriteLine(number);

            number >>= 3;
            Console.WriteLine(number);
            Console.WriteLine("----------------------------------");

        }
        public void ControlstatementsEx()
        {
            int number = 20;
            Console.WriteLine("If");
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} this Number is Even", i);
                }
            }
            Console.WriteLine("If else");
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} this Number is Even", i);
                }
                else
                {
                    Console.WriteLine("{0} this Number is Odd", i);
                }
            }
            Console.WriteLine("If else if");
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} this Number is Even", i);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("{0} this Number is Divided by 3", i);
                }
                else
                {
                    Console.WriteLine("{0} this Number is odd", i);
                }
            }
            Console.WriteLine("Nested If");
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    if (i % 4 == 0)
                    {
                        Console.WriteLine("{0} this Number is Even and Divided By 4", i);
                    }
                }
                else
                {
                    Console.WriteLine("{0} this Number is Odd", i);
                }
            }
        }
        public void BoxingAndUnboxingEx()
        {
            Console.WriteLine("Boxing Example");
            int num = 23;
            Object Obj = num;
            Console.WriteLine("{0} int to Object", Obj);
            Console.WriteLine("UnBoxing Example");
            Object O = 24;
            int i = (int)O;
            Console.WriteLine("{0} Object to int", i);
        }
        public void TypeCasteingEx()
        {
            Console.WriteLine("TypeCasteingEx");
            long i = 10;
            int a = 100;
            string name = "H";
            string price = "100.00";
            string istrue = "true";
            bool b = false;
            Console.WriteLine("Converting The long to int {0}", Convert.ToInt32(i));
            Console.WriteLine("Converting The int to long {0}", Convert.ToInt64(a));
            Console.WriteLine("Converting The boolean to string {0}", Convert.ToString(b));
            Console.WriteLine("Converting The string to char {0}", Convert.ToChar(name));
            Console.WriteLine("Converting The string to boolean {0}", Convert.ToBoolean(istrue));
            Console.WriteLine("Converting The string to double {0}", Convert.ToDouble(price));
        }
        public void LoopsEX()
        {
            Console.WriteLine("Loops Examples");
            Console.WriteLine("For");
            for (int ic = 0; ic <= 10; ic++)
            {
                if (ic % 2 == 0)
                {
                    Console.WriteLine("{0} this Number is Even", ic);
                }
                else
                {
                    Console.WriteLine("{0} this Number is Odd", ic);
                }
            }
            Console.WriteLine("Nested For");
            for (int a = 0; a <= 5; a++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("While");
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("Do While");
            int b = 0;
            do
            {
                Console.WriteLine(b);
                b++;
            }
            while (b < 10);
            Console.WriteLine("------------------------------");

        }
        public void Looppatterns()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------");
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if (i + j == 5 || i + j == 6 || i + j == 7 ||
                        i + j == 8 || i + j == 9 || i + j == 10 ||
                         i + j == 11)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine("---END---");
        }
        public void UnconditionaljumpstatementsEx()
        {
            Console.WriteLine("------UnconditionaljumpstatementsEx-----");
            Console.WriteLine("Break Statement => It's Break on i = 4");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Continue Statement => It's Break on i = 9");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("goto Statement");
            int x = 0;
        Loop: x++;
            if (x <= 10)
            {
                Console.WriteLine(x);
                goto Loop;
            }
            Console.WriteLine("------UnconditionaljumpstatementsEx-----");

        }
        public void PredefinedFunctionEx()
        {
            Console.WriteLine("PredefinedFunctionEx");
            Console.WriteLine("Console,Math,String,Array,DateTime,Convert");
            Console.WriteLine("Console=>WriteLine(),Write(),Readkey()");
            Console.WriteLine("Math=>Max(),Min(),Sqrt(),Abs(),Ceiling(),Floor(),Round()");
            Console.WriteLine("1,10 Max =>" + Math.Max(1, 10));
            Console.WriteLine("5,9 Min =>" + Math.Min(5, 9));
            Console.WriteLine("2 Sqrt =>" + Math.Sqrt(2));
            Console.WriteLine("2 Abs =>" + Math.Abs(2));
            Console.WriteLine("2.4 Ceiling =>" + Math.Ceiling(2.4));
            Console.WriteLine("2.9 Floor =>" + Math.Floor(2.9));
            Console.WriteLine("2.5 Round =>" + Math.Round(2.5));
            Console.WriteLine("String=>Compare(),Concat(),Empty(),IsNullorEmpty(),IsNullorWhitespace()");

            Console.WriteLine("'rahul'=='rahul'Compare  =>" + String.Compare("rahul", "rahul"));
            Console.WriteLine("Concat =>" + String.Concat("rahul", "kondi"));
            Console.WriteLine("Empty =>" + String.Empty);
            string name = "";
            Console.WriteLine("name='' IsNullorEmpty =>" + String.IsNullOrEmpty(name));
            Console.WriteLine("name='' IsNullorWhitespace =>" + String.IsNullOrWhiteSpace(name));
            Console.WriteLine("DateTime => UtcNow =>" + DateTime.UtcNow.Date.Year.ToString());
            Console.WriteLine("DateTime => Now =>" + DateTime.Now.ToString());
            Console.WriteLine("----------------------------------------------------");
            ;

        }
        public void UserdefinedFunctionEx()
        {
            Program a = new Program();
            Console.WriteLine("UserdefinedFunctionEx");
            Console.WriteLine("1)with input and with return Result:" + a.UserdefinedFunctionTYPE1(20, 4));
            Console.WriteLine("2)with input and without return Result:");
            a.UserdefinedFunctionTYPE2(20, 4);
            Console.WriteLine("1)without input and with return Result:" + a.UserdefinedFunctionTYPE3());
            Console.WriteLine("1)with input and with return Result:");
            a.UserdefinedFunctionTYPE4();
        }
        public int UserdefinedFunctionTYPE1(int a, int b)
        {
            return a + b;
        }
        public void UserdefinedFunctionTYPE2(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public string UserdefinedFunctionTYPE3()
        {
            return "Hello World";
        }
        public void UserdefinedFunctionTYPE4()
        {
            Console.WriteLine("Hello World");
        }
        public void StringBuilderEx()
        {
            Console.WriteLine("StringBuilder is Imported form using System.Text;");
            StringBuilder sb = new StringBuilder("A");
            sb.Append(",B");
            sb.Append(",C");
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sb.Length);
            Console.WriteLine("B is replaced by H");
            Console.WriteLine(sb.Replace('B', 'H'));
        }
        public void Arrays()
        {
            Console.WriteLine("Single Dimensional Array Examples :");
            int[] nos = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] arr = new string[] { "Rocky", "Sam", "Tina", "Yoo", "James", "Samantha" };
            Console.WriteLine("Using For");
            for (int x = 0; x < nos.Length - 1; x++)
            {
                Console.WriteLine(arr[x]);
            }
            Console.WriteLine("Using Foreach");
            foreach (string i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        public void List()
        {
            List<string> list = new List<string>
                    {
                        "Rahul",
                        "Ravi",
                        "Sindhu",
                        "Venkatesh",

                    };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Add("Prasad");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After Adding one Element");
            list.Remove("Ravi");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After Removeing Ravi name");
            list.RemoveAt(3);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After Removeing At Index 4 ");
            var data = list.Contains("Rahul");
            Console.WriteLine("Rahul in LIST : " + data.ToString());
            list.Clear();
        }
        //public void Prime()
        //{
        //    Console.Write("Enter a Number : ");
        //    int number = int.Parse(Console.ReadLine());
        //    bool IsPrime = true;
        //    for (int i = 2; i < number / 2; i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            IsPrime = false;
        //            break;
        //        }
        //    }
        //    if (IsPrime)
        //    {
        //        Console.Write("Number is Prime.");
        //    }
        //    else
        //    {
        //        Console.Write("Number is not Prime.");
        //    }
        //    Console.ReadKey();
        //}

        
    }
    public class SingleINHParent
    {
        public string Name = "SingleINHParent";
    }
    public class SingleINHChild: SingleINHParent
    {

    }
    //public class MultipleINHParent1
    //{
    //    public string Name = "MultipleINHParent1";
    //}
    //public class MultipleINHParent2
    //{
    //    public string Name = "MultipleINHParent2";
    //}
    //public class MultipleINHChild: MultipleINHParent1, MultipleINHParent2
    //{
    //    //Error CS1721  Class 'MultipleINHChild' cannot have multiple base classes: 'MultipleINHParent1' and 'MultipleINHParent2'	
    //}
    public class MultilevelINHGrandParent
    {
         public string Name = "MultilevelINHGrandParent";
    }
    public class MultilevelINHParent: MultilevelINHGrandParent
    {
        public string Name1 = "MultilevelINHParent";
    }
    public class MultilevelINHChild: MultilevelINHParent
    {
        public string Name2 = "MultilevelINHChild";
    }
    public class HierarchicalINHParent
    {
        public string Name = "HierarchicalINHParent";
    }
    public class HierarchicalINHChild1: HierarchicalINHParent
    {
    }
    public class HierarchicalINHChild2: HierarchicalINHParent
    {
    }
    #region Hybrid Inhertance
    public class HybridMultilevelINHGrandParent
    {
        public string Name = "HybridMultilevelINHGrandParent";
    }
    public class HybridMultilevelINHParent : MultilevelINHGrandParent
    {
        public string Name1 = "HybridMultilevelINHParent";
    }
    public class HybridMultilevelINHChild1 : MultilevelINHParent
    {
        public string NameChild1 = "HybridMultilevelINHChild1";
    }
    public class HybridMultilevelINHChild2
    {
        public string NameChild2 = "HybridMultilevelINHChild2";
    }

    #endregion 
    public class Employee
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int AddressId { get; set; }
    }
    public class Address
    {
        public int ID { get; set; }
        public string? AddressLine { get; set; }
    }

    public class BaseClass
    {
        public virtual string? Name { get; set; }
    }
    public class DerivedClass : BaseClass
    {
        public override string? Name { get; set; }

    }
}