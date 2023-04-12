class Program {

static void Main() {

        //create three objects for employees
        Employee emp1 = new Employee();//parameter-less constructor
        emp1.setEmpID(101);
        emp1.setEmpName("Scott");
        emp1.setJob("Manager");
        Employee emp2 = new Employee(102, "Allen");
        emp2.setJob("Asst. Manager");
        Employee emp3 = new Employee(103, "Anna", "Clerk");
        //setting fields using object initializer
        Employee emp4 = new Employee(){empName = "Ford",job = "Executive"};

        //display fields
        Console.WriteLine(Employee.companyName);
        Console.WriteLine("\nFirst Employee:");
        Console.WriteLine(emp1.getEmpID());
        Console.WriteLine(emp1.getEmpName());
        Console.WriteLine(emp1.getJob());
        Console.WriteLine();

        Console.WriteLine("Second Employee:");
        Console.WriteLine(emp2.getEmpID());
        Console.WriteLine(emp2.getEmpName());
        Console.WriteLine(emp2.getJob());
        Console.WriteLine();

        Console.WriteLine("Third Employee:");
        Console.WriteLine(emp3.getEmpID());
        Console.WriteLine(emp3.getEmpName());
        Console.WriteLine(emp3.getJob());
        Console.WriteLine();

        Console.ReadKey();


    }


}