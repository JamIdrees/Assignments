using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
   public class Idcard
    {
        public Idcard()
        {

        }
        private float mSignin;

        public float Signin
        {
            get { return mSignin; }
            set { mSignin = value; }
        }
        private float mSignout;

        public float Signout
        {
            get { return mSignout; }
            set { mSignout = value; }
        }
        public float Calculate()
        {
            float cal = Signout - Signin;
            
            Console.WriteLine("Working hours" + cal);
            return cal;
        }
    }
}
