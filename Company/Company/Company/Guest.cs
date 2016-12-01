using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Guest
    {
        public Guest()
        {

        }
        private string mGuestname;

        public string Guestname
        {
            get { return mGuestname; }
            set { mGuestname = value; }
        }
        private string mGuestid;

        public string Guestid
        {
            get { return mGuestid; }
            set { mGuestid = value; }
        }

    }
}
