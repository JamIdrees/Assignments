using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Department mydepartment = new Department();
           Console.WriteLine(mydepartment.DepartmentName = "Department");
            SalesDepartment salesdept = new SalesDepartment();
           Console.WriteLine(salesdept.DepartmentName = "This is sales department");
            MarketingDepartment marketdept = new MarketingDepartment();
           Console.WriteLine( marketdept.DepartmentName = "This is marketting department");
            ITdepartment itdept = new ITdepartment();
           Console.WriteLine( itdept.DepartmentName = "This is I T department");
            Employee employee = new Employee();
           Console.WriteLine( employee.EmployeeId = 4123);
           Console.WriteLine(employee.Employeename = "Mohammed Idrees");
            Idcard Icard = new Idcard();
           
            Icard.Signin = 10.0f;
            Icard.Signout = 20.0f;
            Icard.Calculate();
           
            Console.ReadLine();

        }
    }
}
