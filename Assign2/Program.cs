using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StaffLogicList logic = new StaffLogicList();
            string option;
            Console.WriteLine("###########----Staff Management System----#############");

            List<Staff> st;
            do
            {
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine("1. Get \n2. Register \n3. Update \n4. Delete \n5. Get Staff by Category \n6. Get Staff by Ward \n7. List Staff in Acsending order by StaffName \n8. Calculate income for Each Staff ");
                int sel = Convert.ToInt32(Console.ReadLine());

                switch (sel)
                {
                    case 1:
                        st = logic.GetStaffs();
                        print(st);
                        break;
                    case 2:
                        Console.WriteLine("Enter Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        while(logic.idValidation(id))
                             id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Name: ");
                        string name = Console.ReadLine();
                        while (string.IsNullOrEmpty(name)) {
                            Console.WriteLine("Name cannot be empty: ");
                            name = Console.ReadLine();
                        }


                        Console.WriteLine("Enter Address: ");
                        string address = Console.ReadLine();
                        while (string.IsNullOrEmpty(address))
                        {
                            Console.WriteLine("Address cannot be empty: ");
                            address = Console.ReadLine();
                        }


                        Console.WriteLine("Enter Department Name: ");
                        string dept = Console.ReadLine();
                        while (string.IsNullOrEmpty(dept))
                        {
                            Console.WriteLine("Department name cannot be empty: ");
                            dept = Console.ReadLine();
                        }

                        Console.WriteLine("Enter Category: \n(Categories: Doctor, Nurse, WardBoy, Technicain, Driver) ");
                        string cat = Console.ReadLine();
                        while (string.IsNullOrEmpty(cat))
                        {
                            Console.WriteLine("Category cannot be empty: ");
                            cat = Console.ReadLine();
                        }
                        while (logic.catValidation(cat))
                        {
                            cat = Console.ReadLine();
                        }


                        Console.WriteLine("Enter Income: ");
                        Decimal income = Convert.ToDecimal(Console.ReadLine());
                        while (logic.salValidation(income))
                        {
                            income = Convert.ToDecimal(Console.ReadLine());
                        }
                        Console.WriteLine("Enter Fees: ");
                        Decimal fees = Convert.ToDecimal(Console.ReadLine());


                        Console.WriteLine("Enter Ward: \n (Ward: General, Cancer, Heart, Critical Care) ");
                        string ward = Console.ReadLine();
                        while (string.IsNullOrEmpty(ward))
                        {
                            Console.WriteLine("Ward cannot be empty: ");
                            ward = Console.ReadLine();
                        }
                        while (logic.wardValidation(ward))
                        {
                            ward = Console.ReadLine();
                        }

                        Console.WriteLine("Enter Room: ");
                        string room = Console.ReadLine();
                        while (string.IsNullOrEmpty(room))
                        {
                            Console.WriteLine("Address cannot be empty: ");
                            room = Console.ReadLine();
                        }

                        Staff newStaff = new Staff()
                        {
                            StaffId = id,
                            StaffName = name,
                            Address = address,
                            DeptName = dept,
                            StaffCategory = cat,
                            Income = income,
                            Fees = fees,
                            Ward = ward,
                            Room = room
                        };

                        st = logic.Register(newStaff);
                        print(st);
                        break;
                    case 3:
                        Console.Write("Enter the staff id you want to Update the data: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Address: ");
                        address = Console.ReadLine();
                        Console.WriteLine("Enter Department Name: ");
                        dept = Console.ReadLine();
                        Console.WriteLine("Enter Category: ");
                        cat = Console.ReadLine();
                        Console.WriteLine("Enter Income: ");
                        income = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter Fees: ");
                        fees = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter Ward: ");
                        ward = Console.ReadLine();
                        Console.WriteLine("Enter Room: ");
                        room = Console.ReadLine();

                         Staff neStaff = new Staff()
                        {
                            StaffName = name,
                            Address = address,
                            DeptName = dept,
                            StaffCategory = cat,
                            Income = income,
                            Fees = fees,
                            Ward = ward,
                            Room = room
                        };

                        string res = logic.Update(neStaff,id);
                        Console.WriteLine(res);
                        break;
                    case 4:
                        Console.WriteLine("Enter staff Id You want to delete:");
                        id = Convert.ToInt32(Console.ReadLine());
                        res = logic.Delete(id);
                        Console.WriteLine(res);
                        break;
                    case 5:
                        Console.WriteLine("Enter Ward of staff:");
                        dept = Console.ReadLine();
                        logic.GetByCategory(dept);
                        break;
                    case 6:
                        Console.WriteLine("Enter category of staff:");
                        cat = Console.ReadLine();
                        logic.GetByDept(cat);
                        break;
                    case 7:
                        Console.WriteLine("Sorted list of Staff: ");
                        logic.Sortedbyname();
                        break;
                    case 8:
                        logic.totalIncome();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Enter 'y' if you want to continue...");
                option = Console.ReadLine();
            } while (option == "y");

            Console.ReadLine();
        }  
        public static void print(List<Staff> staff)
        {
            foreach(Staff st in staff)
            {
                Console.WriteLine($"Id:{st.StaffId} \t Name: {st.StaffName} \t Address: {st.Address} \t Dept Name:{st.DeptName} \tCategory: {st.StaffCategory} \tIncome: {st.Income} \tFees: {st.Fees} \tWard: {st.Ward} \tRoom: {st.Room}");
            }
        }
    }
}
