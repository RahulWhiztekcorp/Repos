using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SortedSetProgramsCollectionEX
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //------------------------------ Average -----------------------------//
            SortedSet<int> setnum = new SortedSet<int>();
            setnum.Add(101);
            setnum.Add(1001);
            setnum.Add(10001);
            setnum.Add(100001);
            var data = setnum.Average();
            Console.WriteLine("SortedSet Average Value = " + data);
            //------------------------------ ElementAt ---------------------------//
            SortedSet<int> setnume = new SortedSet<int>();
            setnume.Add(101);
            setnume.Add(1001);
            setnume.Add(10001);
            setnume.Add(100001);
            Console.WriteLine("1st Element in intList: {0}", setnume.ElementAt(0));
            Console.WriteLine("1st Element in intList: {0}", setnume.ElementAt(0));
            //------------------------------ Intersect ---------------------------//
            SortedSet<string> set1 = new SortedSet<string>();
            set1.Add("Rahul");
            set1.Add("Ravi");
            set1.Add("Hello");
            set1.Add("Test");
            set1.Add("Wrld");
            SortedSet<string> set2 = new SortedSet<string>();
            set2.Add("Rahul");
            set2.Add("Ravi");
            set2.Add("Hello1");
            set2.Add("Test1");
            set2.Add("Wrld1");
            var final = set1.Intersect(set2);
            Console.WriteLine("Final Result is: ");
            foreach (var j in final)
            {
                Console.WriteLine("{0}", j);
            }
            ////------------------------------ Join --------------------------------//
            SortedSet<Employee> empset = new SortedSet<Employee>();
            empset.Add(new Employee { ID = 1, Name = "Preety", AddressId = 1 });
            //empset.Add(new Employee { ID = 2, Name = "Priyanka", AddressId = 2 });
            //empset.Add(new Employee { ID = 3, Name = "Anurag", AddressId = 3 });
            //empset.Add(new Employee { ID = 4, Name = "Pranaya", AddressId = 4 });
            //empset.Add(new Employee { ID = 5, Name = "Hina", AddressId = 5 });
            SortedSet<Address> address = new SortedSet<Address>();
            address.Add(new Address { ID = 1, AddressLine = "AddressLine1" });
            //address.Add(new Address { ID = 2, AddressLine = "AddressLine2" });
            //address.Add(new Address { ID = 3, AddressLine = "AddressLine3" });
            //address.Add(new Address { ID = 4, AddressLine = "AddressLine4" });
            //address.Add(new Address { ID = 5, AddressLine = "AddressLine5" });
            var JoinUsingMS = empset.Join(
            address,
            employee => employee.AddressId,
            address => address.ID,
            (employee, address) => new
            {
                EmployeeName = employee.Name,
                AddressLine = address.AddressLine
            }).ToList();

            //Accessing the Result using For Each Loop
            foreach (var employee in JoinUsingMS)
            {
                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            }
            ////------------------------------ Prepend -----------------------------//
            SortedSet<int> no = new SortedSet<int>() { 1, 2, 3, 4, 5 };
            no.Prepend(0);
            foreach (var employee in no)
            {
                Console.WriteLine(employee);
            }
        }
    }
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
}