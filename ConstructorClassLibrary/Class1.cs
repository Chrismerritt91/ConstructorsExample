public class Employee
{

    //fields
    private int _empID;
    private string _empName;
    private string _job;
    private double _salary;
    private double _tax;

    //instance properties
    public int EmpID
    {
        set
        {
            if (value >= 100)
            {
                this._empID = value;
            }
        }
        get { return _empID; }
    }
    public string EmpName { get { return _empName; } set { this._empName = value; } }
    public string Job { get { return _job; } set { this._job = value; } }

    //static field
    private static string _companyName;

    //static property
    public static string CompanyName
    {
        get { return _companyName; }
        set
        {
            if (value.Length <= 20)
            {
                _companyName = value;
            }
        }
    }

    //Explicit constructors
    //Instance Constructors

    public Employee(int empID, string empName, string job)
    {
        this._empID = empID;
        this._empName = empName;
        this._job = job;
        this._salary = 1000;
    }

    public Employee(int empID, string empName)
    {
        this._empID = empID;
        this._empName = empName;
        this._salary = 1000;
    }

    public Employee()
    {
        _empID = 1;
        this._salary = 1000;
    }


    //static constructor
    static Employee()
    {
        _companyName = "ABC Industries";
    }

    //readonly property
    public double Salary { get { return _salary; } }

    //writeonly property
    public double Tax
    {
        set
        {
            if (value >= 0 && value <= 100)
            {
                this._tax = value;
            }
        }
    }

    //method using readonly and writeonly
    public double CalculateNetSalary()
    {
        double t = Salary - _tax;
        return t;
    }

    //automatic property
    public string NativePlace { get; set; } = "New York";





    //Getters and Setters are no longer needed when properties are being used, simpler syntax
    ////Getters

    //public int getEmpID()
    //{
    //    return this.empID;
    //}

    //public string getEmpName()
    //{
    //    return this.empName;
    //}

    //public string getJob()
    //{
    //    return this.job;
    //}

    ////Setters

    //public void setEmpID(int value)
    //{
    //    this.empID = value;
    //}

    //public void setEmpName(string value)
    //{
    //    this.empName = value;
    //}

    //public void setJob(string value)
    //{
    //    this.job = value;
    //}


}