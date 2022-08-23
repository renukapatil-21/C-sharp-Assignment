using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var employees = new EmployeeList();
            //RunTasks(employees);
            ExecuteTasks();

            Console.WriteLine("---------------------------------------------------------------------------------");
            Dictionary<string, List<Employees>> edict = new Dictionary<string, List<Employees>>();
            String[] deptname = { "IT", "HRD", "Accounts", "Sales", "Maintainance" };

            edict.Add(deptname[0], new List<Employees>()
            {
                new Employees() { EmpNo = 101, EmpName = "Tejas", Salary = 12345 },
                new Employees() { EmpNo = 102, EmpName = "Mahesh", Salary = 22345 },
                new Employees() { EmpNo = 103, EmpName = "Amar", Salary = 52345 },
                new Employees() { EmpNo = 104, EmpName = "Kumar", Salary = 22545 },
                new Employees() { EmpNo = 105, EmpName = "Nikhil", Salary = 26545 },
                new Employees() { EmpNo = 106, EmpName = "Rishi", Salary = 52345 },
                new Employees() { EmpNo = 107, EmpName = "Rohan", Salary = 22545 },
                new Employees() { EmpNo = 108, EmpName = "R0hit", Salary = 26545 }
            });
            edict.Add(deptname[1], new List<Employees>()
            {
                new Employees() { EmpNo = 101, EmpName = "Snehit", Salary = 12345 },
                new Employees() { EmpNo = 102, EmpName = "Soham", Salary = 22345 },
                new Employees() { EmpNo = 103, EmpName = "Kumar", Salary = 52345 },
                new Employees() { EmpNo = 104, EmpName = "Tejas", Salary = 22545 },
                new Employees() { EmpNo = 105, EmpName = "Amar", Salary = 26545 },
                new Employees() { EmpNo = 106, EmpName = "Nikhil", Salary = 52345 },
                new Employees() { EmpNo = 107, EmpName = "Mahesh", Salary = 22545 },
                new Employees() { EmpNo = 108, EmpName = "Rishi", Salary = 26545 }
            });
            edict.Add(deptname[2], new List<Employees>()
            {
                new Employees() { EmpNo = 101, EmpName = "Snehit", Salary = 12345 },
                new Employees() { EmpNo = 102, EmpName = "Soham", Salary = 22345 },
                new Employees() { EmpNo = 103, EmpName = "Kumar", Salary = 52345 },
                new Employees() { EmpNo = 104, EmpName = "Tejas", Salary = 22545 },
                new Employees() { EmpNo = 105, EmpName = "Amar", Salary = 26545 },
                new Employees() { EmpNo = 106, EmpName = "Nikhil", Salary = 52345 },
                new Employees() { EmpNo = 107, EmpName = "Mahesh", Salary = 22545 },
                new Employees() { EmpNo = 108, EmpName = "Rishi", Salary = 26545 }
            });
            edict.Add(deptname[3], new List<Employees>()
            {
                new Employees() { EmpNo = 101, EmpName = "Snehit", Salary = 12345 },
                new Employees() { EmpNo = 102, EmpName = "Soham", Salary = 22345 },
                new Employees() { EmpNo = 103, EmpName = "Kumar", Salary = 52345 },
                new Employees() { EmpNo = 104, EmpName = "Tejas", Salary = 22545 },
                new Employees() { EmpNo = 105, EmpName = "Amar", Salary = 26545 },
                new Employees() { EmpNo = 106, EmpName = "Nikhil", Salary = 52345 },
                new Employees() { EmpNo = 107, EmpName = "Mahesh", Salary = 22545 },
                new Employees() { EmpNo = 108, EmpName = "Rishi", Salary = 26545 }
            });
            edict.Add(deptname[4], new List<Employees>()
            {
                new Employees() { EmpNo = 101, EmpName = "Snehit", Salary = 12345 },
                new Employees() { EmpNo = 102, EmpName = "Soham", Salary = 22345 },
                new Employees() { EmpNo = 103, EmpName = "Kumar", Salary = 52345 },
                new Employees() { EmpNo = 104, EmpName = "Tejas", Salary = 22545 },
                new Employees() { EmpNo = 105, EmpName = "Amar", Salary = 26545 },
                new Employees() { EmpNo = 106, EmpName = "Nikhil", Salary = 52345 },
                new Employees() { EmpNo = 107, EmpName = "Mahesh", Salary = 22545 },
                new Employees() { EmpNo = 108, EmpName = "Rishi", Salary = 26545 }
            });

            edict.TryGetValue(deptname[0], out List<Employees> emp1);
            sort(emp1, deptname[0]);
            maxSal(emp1, deptname[0]);
            Console.WriteLine();

            edict.TryGetValue(deptname[1], out List<Employees> emp2);
            sort(emp2, deptname[1]);
            maxSal(emp2, deptname[1]);
            Console.WriteLine();

            edict.TryGetValue(deptname[2], out List<Employees> emp3);
            sort(emp3, deptname[2]);
            maxSal(emp3, deptname[2]);
            Console.WriteLine();

            edict.TryGetValue(deptname[3], out List<Employees> emp4);
            sort(emp4, deptname[3]);
            maxSal(emp4, deptname[3]);
            Console.WriteLine();

            edict.TryGetValue(deptname[4], out List<Employees> emp5);
            sort(emp5, deptname[4]);
            maxSal(emp5, deptname[4]);
            Console.WriteLine();

            Console.ReadLine();
        }

        public static void sort(List<Employees> emp, string deptname)
        {
            Console.WriteLine($"Asceding order by Salary in deptName: {deptname}");
            for (int i = 0; i < emp.Count; i++)
            {
                for (int j = 0; j < emp.Count - i - 1; j++)
                {
                    if (string.Compare(emp[j].EmpName, emp[j + 1].EmpName) > 0)
                    {
                        Employees t = emp[j + 1];
                        emp[j + 1] = emp[j];
                        emp[j] = t;
                    }
                }
            }
            foreach (Employees employee in emp)
            {
                Console.WriteLine($"EmpNo: {employee.EmpNo} EmpName: {employee.EmpName} Salary:{employee.Salary} ");
            }
        }

        public static void maxSal(List<Employees> emp, string deptname)
        {
            Console.WriteLine($"\nMax Salaray in department {deptname}");
            int max = 0;
            for (int i = 0; i < emp.Count - 1; i++)
            {
                max = Math.Max(max, (int)emp[i].Salary);
            }
            foreach (Employees employee in emp)
            {
                if (employee.Salary >= max)
                {
                    Console.WriteLine($"EmpNo: {employee.EmpNo} EmpName: {employee.EmpName} Salary:{employee.Salary} ");

                }
            }
            Console.WriteLine();
        }

        public static void task1()
        {
            Console.WriteLine("List all Employees in Ascending Order by Salary");
            var emp = new EmployeeList();
            var emps = (from e in emp
                        orderby e.Salary ascending
                        select e).ToList();
            foreach (Employee employee in emps)
            {
                Console.WriteLine($"EmpNo: {employee.EmpNo} EmpName: {employee.EmpName} Salary:{employee.Salary} ");
            }
            Console.WriteLine();
        }

        public static void task2()
        {
            Console.WriteLine("calculate Tax for each Employee");
            var emp = new EmployeeList();

            var emps = (from e in emp select e).ToList();

            int Tax = 1000;

            foreach (Employee employee in emps)
            {
                Console.WriteLine($" Empno: {employee.EmpNo} EMpName: {employee.EmpName} Salary: {employee.Salary}  Salary After adding tax: {employee.Salary - Tax} ");
            }
            Console.WriteLine();

        }

        public static void task3()
        {
            Console.WriteLine("Print All Employees with the EmpNo, EmpName, Salary, Tax fashion");
            var emp = new EmployeeList();

            var emps = (from e in emp select e).ToList();

            foreach (Employee employee in emps)
            {
                Console.WriteLine($"EmpNo: {employee.EmpNo} EmpName: {employee.EmpName} Salary:{employee.Salary} ");
            }
            Console.WriteLine();

        }

        public static void ExecuteTasks()
        {
            Task task = Task.Factory.StartNew(task1)
                                    .ContinueWith(delegate { task1(); })
                                    .ContinueWith(delegate { task2(); })
                                    .ContinueWith(delegate { task3(); });
            Console.ReadLine();
        }


        /*static async void RunTasks(EmployeeList employees)
        {
            Task<List<Employee>> task = Task.Factory.StartNew(() =>
                                            { return ListInAscendingOrder(employees); })
                                            .ContinueWith<List<Employee>>((res) =>
                                            { return CalculateAllEmployeeTax(res.Result); });
                                            //.ContinueWith((res) => { print(res.Result)} ) ;
            print(task.Result);
                                                         
        }

        static List<Employee> ListInAscendingOrder(List<Employee> employees)
        {
            var emps = (from e in employees
                        orderby e.Salary ascending
                        select e).ToList();
            return emps;
        }

        static List<Employee> CalculateAllEmployeeTax(List<Employee> employees)
        {
            Console.WriteLine("Calculate All Employee Tax");
            for(int i=0; i<employees.Count; i++)
            {
                employees[i] = ProcessTax.CalculateTax(employees[i]);
            }
            return employees;
        }

        static void print(List<Employee> employees)
        {
            foreach(Employee employee in employees)
            {
                Console.WriteLine($"{employee.EmpNo} {employee.EmpName} {employee.Salary} {employee.Tax}");
            }
        }*/

    }
    public class Employees
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; } = string.Empty;
        public decimal Salary { get; set; }
    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public decimal Tax { get; set; }
    }
    public static class ProcessTax
    {
        public static Employee CalculateTax(Employee emp)
        {
            System.Threading.Thread.Sleep(100);
            emp.Tax = emp.Salary * Convert.ToDecimal(0.4);
            return emp;
        }
    }
    public class EmployeeList : List<Employee>
    {
        public EmployeeList()
        {
            Add(new Employee() { EmpNo = 1, EmpName = "A", Salary = 21000 });
            Add(new Employee() { EmpNo = 2, EmpName = "B", Salary = 22000 });
            Add(new Employee() { EmpNo = 3, EmpName = "C", Salary = 23000 });
            Add(new Employee() { EmpNo = 4, EmpName = "D", Salary = 24000 });
            Add(new Employee() { EmpNo = 5, EmpName = "E", Salary = 25000 });
            Add(new Employee() { EmpNo = 6, EmpName = "F", Salary = 26000 });
            Add(new Employee() { EmpNo = 7, EmpName = "G", Salary = 27000 });
            Add(new Employee() { EmpNo = 8, EmpName = "H", Salary = 28000 });
            Add(new Employee() { EmpNo = 9, EmpName = "I", Salary = 29000 });
            Add(new Employee() { EmpNo = 10, EmpName = "J", Salary = 30000 });
            Add(new Employee() { EmpNo = 11, EmpName = "K", Salary = 31000 });
            Add(new Employee() { EmpNo = 12, EmpName = "L", Salary = 32000 });
            Add(new Employee() { EmpNo = 13, EmpName = "M", Salary = 33000 });
            Add(new Employee() { EmpNo = 14, EmpName = "N", Salary = 34000 });
            Add(new Employee() { EmpNo = 15, EmpName = "O", Salary = 35000 });
            Add(new Employee() { EmpNo = 16, EmpName = "P", Salary = 36000 });
            Add(new Employee() { EmpNo = 17, EmpName = "Q", Salary = 37000 });
            Add(new Employee() { EmpNo = 18, EmpName = "R", Salary = 38000 });
            Add(new Employee() { EmpNo = 19, EmpName = "S", Salary = 39000 });
            Add(new Employee() { EmpNo = 20, EmpName = "T", Salary = 40000 });
            Add(new Employee() { EmpNo = 21, EmpName = "U", Salary = 41000 });
            Add(new Employee() { EmpNo = 22, EmpName = "V", Salary = 42000 });
            Add(new Employee() { EmpNo = 23, EmpName = "W", Salary = 43000 });
            Add(new Employee() { EmpNo = 24, EmpName = "X", Salary = 44000 });
            Add(new Employee() { EmpNo = 25, EmpName = "Y", Salary = 45000 });
            Add(new Employee() { EmpNo = 26, EmpName = "Z", Salary = 46000 });

        }
    }
}
