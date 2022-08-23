using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2
{
    public class Staff
    {
        private int _StatffId;
        public int StaffId
        {
            get { return _StatffId; }
            set { _StatffId = value; }
        }
        private string _StaffName;
        public string StaffName
        {
            get { return _StaffName; }
            set { _StaffName = value; }
        }
        private string _Address;
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        private string _DeptName;
        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value; }
        }
        private string _StaffCategory;
        public string StaffCategory
        {
            get { return _StaffCategory; }
            set { _StaffCategory = value; }
        }
        private decimal _Income;
        public decimal Income
        {
            get { return _Income; }
            set { _Income = value; }
        }
        private decimal _Fees;
        public decimal Fees
        {
            get { return _Fees; }
            set { _Fees = value; }
        }
        private string _Ward;
        public string Ward
        {
            get { return _Ward; }
            set { _Ward = value; }
        }
        private string _Room;
        public string Room
        {
            get { return _Room; }
            set { _Room = value; }
        }
    }

    public class StaffLogicList
    {
        public List<Staff> stf;
        public StaffLogicList()
        {
            stf = new List<Staff>();
        }

        public List<Staff> GetStaffs()
        {
            return stf;
        }

        public List<Staff> Register(Staff staff)
        {
            stf.Add(staff);
            return stf;
        }

        public string Update(Staff staff, int id)
        {
            string msg = " ";
            for (var i = 0; i < stf.Count; ++i)
            {
                if (stf[i].StaffId == id)
                {
                   
                    stf[i].StaffName = staff.StaffName;
                    stf[i].Address = staff.Address;
                    stf[i].DeptName = staff.DeptName;
                    stf[i].StaffName = staff.StaffName;
                    stf[i].StaffCategory = staff.StaffCategory;
                    stf[i].Income = staff.Income;
                    stf[i].Fees = staff.Fees;
                    stf[i].Ward = staff.Ward;
                    stf[i].Room = staff.Room;
                    msg = "Information updated...!";
                }
                else
                {
                    msg = "Id not found";
                }
            }
            return msg;
        }

        public string Delete(int id)
        {
            stf = GetStaffs();
            string msg = " ";
            for(var i=0; i<stf.Count; i++)
            {
                if (stf[i].StaffId == id)
                {
                    stf.Remove(stf[i]);
                    msg = "Information Deleted...!";
                }
                else
                {
                    msg = "Id not found...!";
                }
            }
            return msg;
        }

        private void printStaff(Staff x)
        {
            Console.WriteLine($"Staff id: {x.StaffId}, " +
                              $"staff name: {x.StaffName}, " +
                              $"dept name: {x.DeptName}, " +
                              $"staff category: {x.StaffCategory}, " +
                              $"Income: {x.Income}, " +
                              $"fees: {x.Fees}, ward: " +
                              $"{x.Ward}, " +
                              $"fees: {x.Fees} ");
        }

        public void GetByCategory(string cat)
        {
            foreach (Staff staff in stf)
            {
                if (staff.StaffCategory == cat)
                {
                    printStaff(staff);
                }
                else
                {
                    Console.WriteLine($"Record not present with {cat} category");
                }
            }
        }
        
        public void GetByDept(string dept)
        {
            foreach (Staff staff in stf)
            {
                if (staff.DeptName == dept)
                {
                    printStaff(staff);
                }
                else
                {
                    Console.WriteLine($"Record not present with {dept} department name.");
                }
            }
        }

        public void Sortedbyname()
        {
            List<String> newlist = new List<String>();
            foreach (Staff staff in stf)
            {
                newlist.Add(staff.StaffName);
            }
            newlist.Sort();
            foreach (string staff in newlist)
            {
                foreach (Staff i in stf)
                {
                    if (i.StaffName == staff)
                    {
                        printStaff(i);
                    }
                }
            }
        }

        public void totalIncome()
        {
            foreach (Staff i in stf)
            {
                int income = 0;
                decimal total = (i.Fees * 10) + income;
                Console.WriteLine($"{i.StaffName}'s total income :{total}");
            }
        }

        public bool idValidation(int id)
        {
           bool flag = false;
           foreach(Staff i in stf)
            {
                if (i.StaffId == id)
                {
                    Console.WriteLine("Id Already present");
                    flag = true;
                }
            }
           return flag;
        }

        public bool catValidation(string cat)
        { 
            bool flag = false;

                if (cat != "Doctor" && cat != "Nurse" &&
                cat != "Wardboy" && cat != "Technician" && cat != "Driver")
                {
                    Console.WriteLine("Incorect Staff Category, please enter again");
                    flag = true;
                }
            
            return flag;
        }

        public bool wardValidation(string ward)
        {
            bool flag = false;

                if (ward != "General" && ward != "Cancer" &&
                ward != "Heart" && ward != "Critical Care")
                {
                    Console.WriteLine("Incorect Staff Category, please enter again");
                    flag = true;
                }
            return flag;
        }

        public bool salValidation(decimal sal)
        {
            bool flag = false;

            if (sal <= 0 || sal <= 0)
            {
                Console.WriteLine("Numeric Values MUST not be -ve or 0");
                flag= true;
            }
            return flag;
        }

    }
}
