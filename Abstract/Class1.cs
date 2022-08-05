using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractt
{
    // this is an abstract class
    internal abstract class Company
    {
        // boss and role does not return any value
        public abstract void boss();
        public void role()
        {
            Console.WriteLine("RhoyalSam is: Head of the company");
        }
    }
    //This class was inherited from the class Family
    class Employee : Company
            {
        public override void boss()
        {
            Console.WriteLine("Employee is: first worker");
        }
    }

}
