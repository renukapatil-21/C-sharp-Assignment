using Assign3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Staff System");

            Accounts accounts = new Accounts();

            Doctor doc = new Doctor();
            doc.Name = "Dr. Anil";
            doc.MaxPatientsPerDay = 100;
            doc.Fees = 350;

            StaffLogic logic = new DoctorLogic();
            accounts.FindStaffIncome(logic, doc);

            Nurse nurse = new Nurse();
            nurse.Name = "Ms. Benza";
            nurse.NoOfPatientsPerWard = 40;

            logic = new NurseLogic();
            accounts.FindStaffIncome(logic, nurse);

            Console.WriteLine("\n####-----Hospital Staff Management System-----####");

            
            Console.WriteLine("\n Enter 1: Doctor \t2.Nurse");
            int sel1 = Convert.ToInt32(Console.ReadLine());
            char y = ' ';

            if (sel1 == 1)
            {
                Console.WriteLine("--------------------Welcome to the Doctors system------------------------");
                DoctorLogic drlogic = new DoctorLogic();
                List<Staff> drl;
                do
                {
                    Console.WriteLine("\n1. Get \n2.Get by ID \n3.Register \n4.Update \n5.Delete");
                    int sel2 = Convert.ToInt32(Console.ReadLine());

                    switch (sel2)
                    {
                        case 1:
                            drl = drlogic.Get();
                            printL(drl);
                            break;
                        case 2:
                            Console.Write("Enter Id: ");
                            int idd = Convert.ToInt32(Console.ReadLine());
                            drlogic.Get(idd);
                            break;
                        case 3:
                            Console.Write("Enter Id: ");
                            idd = Convert.ToInt32(Console.ReadLine());
                            while (drlogic.idValidation(idd))
                            {
                                idd = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter Address: ");
                            string adr = Console.ReadLine();
                            Console.Write("Enter BasicSalary: ");
                            decimal bs = Convert.ToDecimal(Console.ReadLine());
                            Console.Write("Enter Department no.: ");
                            int deptno = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Education: ");
                            string edu = Console.ReadLine();
                            Console.Write("Enter Specialization: ");
                            string spl = Console.ReadLine();
                            Console.Write("Enter Fees: ");
                            decimal fee = Convert.ToDecimal(Console.ReadLine());
                            Console.Write("Enter Max Patients per day: ");
                            int mppd = Convert.ToInt32(Console.ReadLine());


                            Doctor newDr = new Doctor()
                            {
                                Id = idd,
                                Name = name,
                                Address = adr,
                                BasicSalary = bs,
                                DeptNo = deptno,
                                Education = edu,
                                Specilization = spl,
                                Fees = fee,
                                MaxPatientsPerDay = mppd
                            };
                            drlogic.Register(newDr);
                            break;
                        case 4:
                            Console.Write("Enter Id: ");
                            idd = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Name: ");
                            name = Console.ReadLine();
                            Console.Write("Enter Address: ");
                            adr = Console.ReadLine();
                            Console.Write("Enter BasicSalary: ");
                            bs = Convert.ToDecimal(Console.ReadLine());
                            Console.Write("Enter Department no.: ");
                            deptno = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Education: ");
                            edu = Console.ReadLine();
                            Console.Write("Enter Specialization: ");
                            spl = Console.ReadLine();
                            Console.Write("Enter Fees: ");
                            fee = Convert.ToDecimal(Console.ReadLine());
                            Console.Write("Enter Max Patients per day: ");
                            mppd = Convert.ToInt32(Console.ReadLine());

                            Doctor newUDr = new Doctor()
                            {
                                Name = name,
                                Address = adr,
                                BasicSalary = bs,
                                DeptNo = deptno,
                                Education = edu,
                                Specilization = spl,
                                Fees = fee,
                                MaxPatientsPerDay = mppd
                            };
                            drlogic.Update(idd, newUDr);
                            break;
                        case 5:
                            Console.Write("Enter Id: ");
                            idd = Convert.ToInt32(Console.ReadLine());
                            drlogic.Delete(idd);
                            break;
                        default:
                            break;
                    }

                    Console.Write("Enter 'y' if you want to continue or Enter 'n' if you want Nurse System: ");
                    y = Convert.ToChar(Console.ReadLine());


                   /* if (y == 'z')
                    {
                        goto nurse;
                    }*/

                } while (y == 'y');
            }

            //nurse:
             //   Console.WriteLine("Are you sure to quit Doctor console? if yes press 2 ");
                //sel1  = Convert.ToInt32(Console.ReadLine());
            else if (sel1 == 2)
            {
                Console.WriteLine("--------------------Welcome to the Nurse system------------------------");
                
                NurseLogic nrlogic = new NurseLogic();
                List<Staff> nrl;

                do
                {
                    Console.WriteLine("\n1. Get \n2.Get by ID \n3.Register \n4.Update \n5.Delete");
                    int sel2 = Convert.ToInt32(Console.ReadLine());
                    switch (sel2)
                    {
                        case 1:
                            nrl = nrlogic.Get();
                            printN(nrl);
                            break;
                        case 2:
                            Console.Write("Enter Id: ");
                            int idd = Convert.ToInt32(Console.ReadLine());
                            nrlogic.Get(idd);
                            break;
                        case 3:
                            Console.Write("Enter Id: ");
                            idd = Convert.ToInt32(Console.ReadLine());
                            while (nrlogic.idValidation(idd))
                            {
                                idd = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter Address: ");
                            string adr = Console.ReadLine();
                            Console.Write("Enter BasicSalary: ");
                            decimal bs = Convert.ToDecimal(Console.ReadLine());
                            Console.Write("Enter Department no.: ");
                            int deptno = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Ward Name: ");
                            string wn = Console.ReadLine();
                            Console.Write("Enter RoomNo: ");
                            string room = Console.ReadLine();
                            Console.Write("Enter Experties: ");
                            string exp = Console.ReadLine();
                            Console.Write("No of Patients per ward: ");
                            int nppw = Convert.ToInt32(Console.ReadLine());


                            Nurse newnr = new Nurse()
                            {
                                Id = idd,
                                Name = name,
                                Address = adr,
                                BasicSalary = bs,
                                DeptNo = deptno,
                                WardName = wn,
                                RoomNo = room,
                                Expertise = exp,
                                NoOfPatientsPerWard = nppw
                            };
                            nrlogic.Register(newnr);
                            break;
                        case 4:
                            Console.Write("Enter Id: ");
                            idd = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Name: ");
                            name = Console.ReadLine();
                            Console.Write("Enter Address: ");
                            adr = Console.ReadLine();
                            Console.Write("Enter BasicSalary: ");
                            bs = Convert.ToDecimal(Console.ReadLine());
                            Console.Write("Enter Department no.: ");
                            deptno = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter WardName: ");
                            wn = Console.ReadLine();
                            Console.Write("Enter Room no: ");
                            room = Console.ReadLine();
                            Console.Write("Enter Experties: ");
                            exp = Console.ReadLine();
                            Console.Write("No of Patients per ward: ");
                            nppw = Convert.ToInt32(Console.ReadLine());

                            Nurse newunr = new Nurse()
                            {
                                Name = name,
                                Address = adr,
                                BasicSalary = bs,
                                DeptNo = deptno,
                                WardName = wn,
                                RoomNo = room,
                                Expertise = exp,
                                NoOfPatientsPerWard = nppw
                            };
                            nrlogic.Update(idd, newunr);
                            break;
                        case 5:
                            Console.Write("Enter Id: ");
                            idd = Convert.ToInt32(Console.ReadLine());
                            nrlogic.Delete(idd);
                            break;
                        default:
                            break;
                    }
                    Console.Write("Enter 'y' if you want to continue ");
                    y = Convert.ToChar(Console.ReadLine());
                } while (y == 'y');

            }
            else
            {
                Console.WriteLine("Invalid entry");
            }

            Console.ReadLine();

        }
        public static void printL(List<Staff> staff)
        {
            //Console.WriteLine("Id \t Name \t Address \t Basic Salary \t Dept No \t Education \t Fees \t Specialization \t tMaxPatientsPerDay");
            foreach (Doctor st in staff)
            {
                Console.WriteLine($"Id:{st.Id} \tName: {st.Name} \tAddress: {st.Address} \tBasic Salary:{st.BasicSalary} \tDept no: {st.DeptNo} \tEducation: {st.Education} \tFees: {st.Fees} \tSpecialization: {st.Specilization} \tMaxPatientsPerDay: {st.MaxPatientsPerDay}");
                //Console.WriteLine($"{st.Id} \t {st.Name} \t{st.Address} \t{st.BasicSalary} \t{st.DeptNo} \t{st.Education} \t{st.Fees} \t{st.Specilization} \t{st.MaxPatientsPerDay}");
            }
        }
        public static void printN(List<Staff> staff)
        {
            //Console.WriteLine("Id \t Name \t Address \t Basic Salary \t Dept No \t Education \t Fees \t Specialization \t tMaxPatientsPerDay");
            foreach (Nurse st in staff)
            {
                Console.WriteLine($"Id:{st.Id} \tName: {st.Name} \tAddress: {st.Address} \tBasic Salary:{st.BasicSalary} \tDept no: {st.DeptNo} \tWardName: {st.WardName} \tRoomNo: {st.RoomNo} \tExperties: {st.Expertise} \tNoOfPatientsPerWard: {st.NoOfPatientsPerWard}");
                //Console.WriteLine($"{st.Id} \t {st.Name} \t{st.Address} \t{st.BasicSalary} \t{st.DeptNo} \t{st.Education} \t{st.Fees} \t{st.Specilization} \t{st.MaxPatientsPerDay}");
            }
        }
    }


    public class Accounts
    {
        /// <summary>
        /// Dynmaic Polymorphism for deciding the Logic Class Instance and Staff Type 
        /// </summary>
        /// <param name="logic"></param>
        /// <param name="staff"></param>
        public void FindStaffIncome(StaffLogic logic, Staff staff)
        {
            decimal income = logic.CalcluateIncome(staff);
            Console.WriteLine($"Salarty of Staff {staff.Name} is  = Rs.{logic.CalcluateIncome(staff)}/-");
        }
    }
}
