class Program {

static void Main() {

        //create three objects for employees
        Employee emp1 = new Employee(101, "Scott", "Manager");
        Employee emp2 = new Employee(102, "Allen", "Asst. Manager");
        Employee emp3 = new Employee(103, "Anna", "Clerk");

        //display fields
        Console.WriteLine("First Employee:");
        Console.WriteLine(emp1.empID);
        Console.WriteLine(emp1.empName);
        Console.WriteLine(emp1.job);
        Console.WriteLine();

        Console.WriteLine("Second Employee:");
        Console.WriteLine(emp2.empID);
        Console.WriteLine(emp2.empName);
        Console.WriteLine(emp2.job);
        Console.WriteLine();

        Console.WriteLine("Third Employee:");
        Console.WriteLine(emp3.empID);
        Console.WriteLine(emp3.empName);
        Console.WriteLine(emp3.job);
        Console.WriteLine();

        Console.ReadKey();


    }


}