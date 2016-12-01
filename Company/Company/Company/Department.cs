using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
  public  class Department 
    {
        public Department()
        {

        }
        private string mDepartmentName;

        public string DepartmentName
        {
            get { return mDepartmentName; }
            set { mDepartmentName = value; }
        }

      
        public bool validate()
        {
            return true;
        }
     
    }
}
