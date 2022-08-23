using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3.Models
{
    /// <summary>
    /// The class which cannot be Instantiated
    /// </summary>
    public abstract class StaffLogic
    {
        public abstract List<Staff> Get();
        public abstract Staff Get(int id);
        public abstract Staff Register(Staff staff);
        public abstract Staff Update(int id, Staff staff);
        public abstract bool Delete(int id);

        /// <summary>
        /// A Default Implementation for Staff to Calculate Income
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public virtual decimal CalcluateIncome(Staff staff)
        {
            return staff.BasicSalary;
        }
    }

    /// <summary>
    /// MUST Override all abstract methods
    /// Since Doctor is-a Staff, we can pass the the Doctor as an input parameter
    /// as-well-as we can have Doctor as an output parameter at Run-Time and not as Compile-Time
    /// This is a 'Runtime or Dynamic Polymorphism'
    /// </summary>
    public class DoctorLogic : StaffLogic
    {
        public List<Staff> drlist;
        public DoctorLogic()
        {
            drlist = new List<Staff>();
        }

        public override List<Staff> Get()
        {
            return drlist;
        }

        public override Staff Get(int id)
        {
            foreach (Staff staff in drlist)
            {
                if (staff.Id == id)
                {
                    Doctor doctor = (Doctor)staff;
                    Console.WriteLine($"Id: {doctor.Id} \t" +
                                      $"Name:{doctor.Name} \t" +
                                      $" Address: {doctor.Address} \t " +
                                      $" Basic Salary: {doctor.BasicSalary} \t " +
                                      $"DepartmentNo: {doctor.DeptNo} \t " +
                                      $"Education: {doctor.Education} \t " +
                                      $"Specialization: {doctor.Specilization} \t: " +
                                      $"Fees: {doctor.Fees} \t " +
                                      $"MaxPatientsPerDay: {doctor.MaxPatientsPerDay} ");
                    return staff;
                }
            }
            return null;
        }

        public override Staff Register(Staff staff)
        {
            drlist.Add(staff);
            Console.WriteLine("Staff Added sucessfully....!");
            return staff;

        }

        public override Staff Update(int id, Staff staff)
        {
            Doctor sd = (Doctor)staff;
            foreach (Staff stafff in drlist)
            {
                Doctor dr = (Doctor)stafff;
                if (dr.Id == id)
                {
                    dr.Name = sd.Name;
                    dr.Address = sd.Address;
                    dr.BasicSalary = sd.BasicSalary;
                    dr.DeptNo = sd.DeptNo;
                    dr.Education = sd.Education;
                    dr.Specilization = sd.Specilization;
                    dr.Fees = sd.Fees;
                    dr.MaxPatientsPerDay = sd.MaxPatientsPerDay;
                }
            }
            return staff;
        }

        public override bool Delete(int id)
        {
            foreach (Staff staff in drlist)
            {
                if (staff.Id == id)
                {
                    drlist.Remove(staff);
                    Console.WriteLine("Doctor deleted");
                    return true;
                }
            }
            Console.WriteLine("Id is not present");
            return false;
        }
        
        public bool idValidation(int id)
        {
            bool flag = false;
            foreach (Staff i in drlist)
            {
                    if (i.Id == id)
                    {
                        Console.WriteLine("Id Already present");
                        flag = true;
                    }
            }
            return flag;
        }
        
        public override decimal CalcluateIncome(Staff staff)
        {
            decimal perDayIncome = ((Doctor)staff).MaxPatientsPerDay * ((Doctor)staff).Fees;
            decimal monthlyFees = perDayIncome * 30;
            // Get the basic Salary  
            decimal grossIncome = base.CalcluateIncome(staff) + monthlyFees;
            return grossIncome;
        }
    }


    public class NurseLogic : StaffLogic
    {
        public List<Staff> nrlist;

        public NurseLogic()
        {
            nrlist = new List<Staff>();
        }

        public override List<Staff> Get()
        {
            return nrlist;
        }

        public override Staff Get(int id)
        {
            foreach (Staff staff in nrlist)
            {
                if (staff.Id == id)
                {
                    Nurse nurse = (Nurse)staff;
                    Console.WriteLine($"Id: {nurse.Id} \t" +
                                      $"Name:{nurse.Name} \t" +
                                      $"Address: {nurse.Address} \t " +
                                      $"Basic Salary: {nurse.BasicSalary} \t " +
                                      $"DepartmentNo: {nurse.DeptNo} \t " +
                                      $"Ward Name: {nurse.WardName} \t " +
                                      $"Room No: {nurse.RoomNo} \t: " +
                                      $"Experties: {nurse.Expertise} \t " +
                                      $"NoOfPatientsPerWard: {nurse.NoOfPatientsPerWard} ");
                    return staff;
                }
            }
            return null;
        }

        public override Staff Register(Staff staff)
        {
            nrlist.Add(staff);
            Console.WriteLine("Staff Added sucessfully....!");
            return staff;

        }

        public override Staff Update(int id, Staff staff)
        {
            Nurse sd = (Nurse)staff;
            foreach (Staff stafff in nrlist)
            {
                Nurse nr = (Nurse)stafff;
                if (nr.Id == id)
                {
                    nr.Name = sd.Name;
                    nr.Address = sd.Address;
                    nr.BasicSalary = sd.BasicSalary;
                    nr.DeptNo = sd.DeptNo;
                    nr.WardName = sd.WardName;
                    nr.RoomNo = sd.RoomNo;
                    nr.Expertise = sd.Expertise;
                    nr.NoOfPatientsPerWard = sd.NoOfPatientsPerWard;
                }
            }
            return staff;
        }

        public override bool Delete(int id)
        {
            foreach (Staff staff in nrlist)
            {
                if (staff.Id == id)
                {
                    nrlist.Remove(staff);
                    Console.WriteLine("Nurse deleted");
                    return true;
                }
            }
            Console.WriteLine("Id is not present");
            return false;
        }

        public bool idValidation(int id)
        {
            bool flag = false;
            foreach (Staff i in nrlist)
            {
                if (i.Id == id)
                {
                    Console.WriteLine("Id Already present");
                    flag = true;
                }
            }
            return flag;
        }

        public override decimal CalcluateIncome(Staff staff)
        {
            decimal collectionPerDay = ((Nurse)staff).NoOfPatientsPerWard * 400;
            decimal monthlyCollection = collectionPerDay * 30;
            decimal grossCololection = base.CalcluateIncome(staff) + monthlyCollection;
            return grossCololection;
        }
    }

}
