namespace HashSetProgramsCollectionEX
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //------------------------------ Average -----------------------------//
            HashSet<int> hashstr = new HashSet<int>() { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };
            var datah = hashstr.Average();
            Console.WriteLine("HashSet Average Value = " + datah);
            //------------------------------ ElementAt ---------------------------//
            HashSet<int> hashstre = new HashSet<int>() { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };
            Console.WriteLine("1st Element in intList: {0}", hashstre.ElementAt(0));
            Console.WriteLine("1st Element in intList: {0}", hashstre.ElementAt(0));
            //------------------------------ Intersect ---------------------------//
            HashSet<string> set1 = new HashSet<string>();
            set1.Add("Rahul");
            set1.Add("Ravi");
            set1.Add("Hello");
            set1.Add("Test");
            set1.Add("Wrld");
            HashSet<string> set2 = new HashSet<string>();
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
            //------------------------------ Join --------------------------------//
            HashSet<Employee> empset = new HashSet<Employee>();
            empset.Add(new Employee { ID = 1, Name = "Preety", AddressId = 1 });
            empset.Add(new Employee { ID = 2, Name = "Priyanka", AddressId = 2 });
            empset.Add(new Employee { ID = 3, Name = "Anurag", AddressId = 3 });
            empset.Add(new Employee { ID = 4, Name = "Pranaya", AddressId = 4 });
            empset.Add(new Employee { ID = 5, Name = "Hina", AddressId = 5 });
            HashSet<Address> address = new HashSet<Address>();
            address.Add(new Address { ID = 1, AddressLine = "AddressLine1" });
            address.Add(new Address { ID = 2, AddressLine = "AddressLine2" });
            address.Add(new Address { ID = 3, AddressLine = "AddressLine3" });
            address.Add(new Address { ID = 4, AddressLine = "AddressLine4" });
            address.Add(new Address { ID = 5, AddressLine = "AddressLine5" });
            var JoinUsingMS = empset.Join(
            address,
            employee => employee.AddressId,
            address => address.ID,
            (employee, address) => new
            {
                EmployeeName = employee.Name,
                AddressLine = address.AddressLine
            }).ToList();
            foreach (var emp in JoinUsingMS)
            {
                Console.WriteLine($"Name :{emp.EmployeeName}, Address : {emp.AddressLine}");
            }
            //------------------------------ Prepend -----------------------------// 
            HashSet<int> no = new HashSet<int>() { 1, 2, 3, 4, 5 };
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