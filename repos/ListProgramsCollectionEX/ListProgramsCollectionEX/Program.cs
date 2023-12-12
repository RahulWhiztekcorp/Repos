namespace ListProgramsCollectionEX
{
    public class Program
    {
        static void Main(string[] args)
        {   
            //------------------------------ Average -----------------------------//
            int[] intNumbers = new int[] { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };
            //Using Method Syntax
            var MSAverageValue = intNumbers.Average();
            //Using Query Syntax
            var QSAverageValue = (from num in intNumbers
                                  select num).Average();
            Console.WriteLine("List Average Value(Using Method) = " + MSAverageValue);
            Console.WriteLine("List Average Value(Using Query) = " + QSAverageValue);
            //----------------------------- ElementAt ------------------------------//
            List<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            List<string> strList = new List<string>() { "One", "Two", "There", "Four", "Five" };

            Console.WriteLine("1st Element in intList: {0}", intList.ElementAt(0));
            Console.WriteLine("1st Element in intList: {0}", strList.ElementAt(0)); 
            //------------------------------ Intersect -----------------------------//
            List<int> data1 = new List<int>() { 10, 20, 30, 40, 50, 60, 70 };
            List<int> data2 = new List<int>() { 50, 60, 70, 80, 90, 100 };

            var final = data1.Intersect(data2);

            Console.WriteLine("Final Result is: ");
            foreach (var j in final)
            {
                Console.WriteLine("{0}", j);
            }
            //----------------------------- Join ------------------------------//
            List<Employee> emp = new List<Employee>()
            {
                new Employee { ID = 1, Name = "Preety", AddressId = 1 },
                new Employee { ID = 2, Name = "Priyanka", AddressId = 2 },
                new Employee { ID = 3, Name = "Anurag", AddressId = 3 },
                new Employee { ID = 4, Name = "Pranaya", AddressId = 4 },
                new Employee { ID = 5, Name = "Hina", AddressId = 5 },
                new Employee { ID = 6, Name = "Sambit", AddressId = 6 },
                new Employee { ID = 7, Name = "Happy", AddressId = 7},
                new Employee { ID = 8, Name = "Tarun", AddressId = 8 },
                new Employee { ID = 9, Name = "Santosh", AddressId = 9 },
                new Employee { ID = 10, Name = "Raja", AddressId = 10},
                new Employee { ID = 11, Name = "Sudhanshu", AddressId = 11}
            };
            List<Address> address = new List<Address>()
            {
                new Address { ID = 1, AddressLine = "AddressLine1"},
                new Address { ID = 2, AddressLine = "AddressLine2"},
                new Address { ID = 3, AddressLine = "AddressLine3"},
                new Address { ID = 4, AddressLine = "AddressLine4"},
                new Address { ID = 5, AddressLine = "AddressLine5"},
                new Address { ID = 9, AddressLine = "AddressLine9"},
                new Address { ID = 10, AddressLine = "AddressLine10"},
                new Address { ID = 11, AddressLine = "AddressLine11"},
            };
            var JoinUsingMS = emp.Join(
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
            //------------------------------ Prepend -----------------------------//
            List<int> no = new List<int>() { 1, 2, 3, 4, 5 };
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