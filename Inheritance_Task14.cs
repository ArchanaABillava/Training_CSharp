using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{

    public class bonus
    {
        protected int amt;
        protected void EmpDetails()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Congrats!!!You got your bonus");
            Console.WriteLine("---------------------------------");
        }
    }
    /// <summary>
    /// Child class - can access the protected variables - Single
    /// </summary>
    public class staff : bonus
    {
        protected int tot_sal1;
        protected int did;
        protected string dname;
        protected int eid;
        protected string ename;


        public void DeptDetails()
        {
            eid = 100;
            ename = "Archana";
            dname = "IT";
            EmpDetails();
            tot_sal1 = 3 * amt;

            Console.WriteLine($"Employee_ID:{eid} Employee_Name:{ename} Department_Name:{dname}");
            Console.WriteLine("");
            Console.WriteLine("You got the bonus of " + tot_sal1);
            Console.WriteLine("--------------------------------------------------------------");



        }
    }
    /// <summary>
    /// Child class - can access the protected variables - Multi-level
    /// </summary>
    public class non_staff : staff
    {
        /// <summary>
        /// Assign the values for the eid and ename from Emp class
        /// Assign the values for the did and dname from ITDept class
        /// </summary>
        protected int tot_sal2;
        protected int sid;
        protected string sname;
        protected string nsname;

        public void GetDetails()
        {
            amt = 1000;
            sid = 2000;
            sname = "John";
            nsname = "Non-IT";
            EmpDetails();
            tot_sal2 = 2 * amt;
            Console.WriteLine($"Employee_ID:{sid} Employee_Name:{sname} Department:{nsname}");
            Console.WriteLine("");
            Console.WriteLine("You got the bonus of " + tot_sal2);


        }

    }
    /// <summary>
    /// Child class - can access the protected variables - Hybrid,Hierarchial
    /// </summary>

    ///public class ITStafff : ITDept
    ///{
    //public void Message()
    //{
    // Console.WriteLine($"{did}:{dname}");
    //}
    //}
    internal class Inheritance_Task14
    {
        public static void Main()
        {
            //Instance for the child class
            //ITDept dept = new ITDept();
            //dept.GetDetails();

            non_staff ns = new non_staff();
            ns.GetDetails();
            ns.DeptDetails();
            //ITStaff iTStaff = new ITStaff();
            //iTStaff.Message();

        }
    }
}
