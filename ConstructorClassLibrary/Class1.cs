public class Employee {

    //fields
    public int empID;
    public string empName;
    public string job;

    //constructors

    //empty constructor used for instantiating object then later using setters to create field values
    public Employee() {}

    public Employee(int empID, string empName, string job) {
        this.empID = empID;
        this.empName = empName;
        this.job = job;
    }


    //Getters

    public int getEmpID() {
        return this.empID;
    }

    public string getEmpName() {
        return this.empName;
    }

    public string getJob() {
        return this.job;
    }

    //Setters

    public void setEmpID(int value) {
        this.empID = value;
    }

    public void setEmpName(string value) {
        this.empName = value;
    }

    public void setJob(string value) {
        this.job = value;
    }


}