using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class SalesDepartment : Department
    {
        public SalesDepartment()
        {

        }
        private string mDepartmentName;

        public string DepartmentName
        {
            get { return mDepartmentName; }
            set { mDepartmentName = value; }
        }

      
    }

}
