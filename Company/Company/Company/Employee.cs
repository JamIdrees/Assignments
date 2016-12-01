using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Employee
    {
        public Employee()
        {

        }
        private int mEmployeeId;

        public int EmployeeId
        {
            get { return mEmployeeId; }
            set { mEmployeeId = value; }
        }

        private string mEmployeename;

        public string Employeename
        {
            get { return mEmployeename; }
            set { mEmployeename = value; }
        }
        private string mEmployeenumber;

        public string Employeenumber
        {
            get { return mEmployeenumber; }
            set { mEmployeenumber = value; }
        }
        public bool validate()
        {
            return true;
        }

    }
}
