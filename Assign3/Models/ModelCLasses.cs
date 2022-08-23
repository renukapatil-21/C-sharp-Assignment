using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3.Models
{
    public class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; } // if(DeptName != null){} OR if(String.IsNotNullOrEmpty(DeptName))
        public int Capacity { get; set; }
    }

    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public decimal BasicSalary { get; set; }
        public int DeptNo { get; set; } // Reference of DeptNo from Department Class
        // public Department Department { get; set; } // Reference from the Department Object (Used in case of Database Mapping)
    }
    /// <summary>
    /// Single Inheritence
    /// </summary>
    public class Doctor : Staff
    {
        public string Education { get; set; } = string.Empty;
        public string Specilization { get; set; } = string.Empty;
        public decimal Fees { get; set; }
        public int MaxPatientsPerDay { get; set; }
    }
    /// <summary>
    /// Since ythje Staff is Base for More Than one classes this will be Hierarchical Inheritence
    /// </summary>
    public class Nurse : Staff
    {
        public string WardName { get; set; } = string.Empty;
        public string RoomNo { get; set; } = string.Empty;
        public string Expertise { get; set; } = string.Empty;
        public int NoOfPatientsPerWard { get; set; }
    }
}
