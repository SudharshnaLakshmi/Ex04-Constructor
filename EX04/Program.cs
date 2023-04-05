using System;
public class Employee
{
    public String designation;
    public String employee_name;
    public int exp;
    public int bs;
    public int insurance;
    double hra, ta, salary;

    public Employee(String employee_name, String designation, int exp, int bs, int i)
    {
        this.employee_name = employee_name;
        this.designation = designation;
        this.exp = exp;
        this.bs = bs;
        this.insurance = i;
    }
    public void sal()
    {
        hra = this.bs * 0.2;
        ta = this.bs * 0.1;
        salary = this.bs + hra + ta - this.insurance;

    }
    public void display()
    {

        Console.WriteLine("Name of the employee is {0} having {1} of experience,working as {2}", this.employee_name, this.exp, this.designation);
        Console.WriteLine("Receives {0} of salary.", salary);

    }

}
class TestEmployee
{
    public static void Main(string[] args)
    {
        Employee e1 = new Employee("SUDHARSHNA", "MANAGER", 8, 300000, 5000);
        e1.sal();
        Employee e2 = new Employee("SHRI", "TEAM LEADER", 5, 45000, 3000);
        e2.sal();
        e1.display();
        e2.display();

    }
}