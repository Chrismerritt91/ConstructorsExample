class Program {

static void Main() {

        //create three objects for employees
        Employee emp1 = new Employee();//parameter-less constructor
        emp1.EmpID = 101;
        emp1.EmpName = "Scott";
        emp1.Job = "Manager";
        emp1.Tax = 50;
        emp1.NativePlace = "New Dehli";
        Employee emp2 = new Employee(102, "Allen");
        emp2.Job = "Asst. Manager";
        Employee emp3 = new Employee(103, "Anna", "Clerk");
        //setting fields using object initializer/ use property names instead of field name
        Employee emp4 = new Employee(){EmpName = "Ford",Job = "Executive"};

        //display fields
        Console.WriteLine(Employee.CompanyName);
        Console.WriteLine("\nFirst Employee:");
        Console.WriteLine(emp1.EmpID);
        Console.WriteLine(emp1.EmpName);
        Console.WriteLine(emp1.Job);
        Console.WriteLine(emp1.Salary);
        Console.WriteLine(emp1.CalculateNetSalary());
        Console.WriteLine(emp1.NativePlace);
        Console.WriteLine();

        Console.WriteLine("Second Employee:");
        Console.WriteLine(emp2.EmpID);
        Console.WriteLine(emp2.EmpName);
        Console.WriteLine(emp2.Job);
        Console.WriteLine(emp2.Salary);
        Console.WriteLine(emp2.NativePlace);
        Console.WriteLine();

        Console.WriteLine("Third Employee:");
        Console.WriteLine(emp3.EmpID);
        Console.WriteLine(emp3.EmpName);
        Console.WriteLine(emp3.Job);
        Console.WriteLine(emp3.Salary);
        Console.WriteLine(emp3.NativePlace);
        Console.WriteLine();

        Console.ReadKey();


    }


}