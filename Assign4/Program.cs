using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1: Lambda Function");
            String[] names = new String[] { "Ram", "Shankar", "Ramesh", "Vivek", "Satish", "Mukesh", "Sandeep", "Vinay", "Mahesh", "Tushar", "Tejas", "Suprotim", "Vikram", "Subodh", "Pravin", "Amit", "Ajit", "Anhijit", "Sharad", "Sanjay", "Vijay", "Abhay", "Vilas", "Anil", "Nandu", "Jaywant", "Shyam" };

            Printoddlength(names);
            Printlengthmorethan7(names);

            Console.Write("Enter Character to get names startwith: ");
            char input = Convert.ToChar(Console.ReadLine());
            PrintStartWith(names, input);
            Console.Write("\nEnter Character to get names Contains character name: ");
            input = Convert.ToChar(Console.ReadLine());
            PrintContains(names, input);

            Console.WriteLine("\n-------------------Question 1: Extension Methods------------------------");
            string str = "The James Bond series focuses on a fictional British Secret Service agent created in 1953 by writer Ian Fleming, who featured him in twelve novels and two short-story collections. Since Fleming's death in 1964, eight other authors have written authorised Bond novels or novelisations: Kingsley Amis, Christopher Wood, John Gardner, Raymond Benson, Sebastian Faulks, Jeffery Deaver, William Boyd, and Anthony Horowitz. The latest novel is Forever and a Day by Anthony Horowitz, published in May 2018. Additionally Charlie Higson wrote a series on a young James Bond, and Kate Westbrook wrote three novels based on the diaries of a recurring series character, Moneypenny.The character—also known by the code number 007 (pronounced \"double-O-seven\")—has also been adapted for television, radio, comic strip, video games and film. The films are one of the longest continually running film series and have grossed over US$7.04 billion in total, making it the fifth-highest-grossing film series to date, which started in 1962 with Dr. No, starring Sean Connery as Bond. As of 2021, there have been twenty-five films in the Eon Productions series. The most recent Bond film, No Time to Die (2021), stars Daniel Craig in his fifth portrayal of Bond; he is the sixth actor to play Bond in the Eon series. There have also been two independent productions of Bond films: Casino Royale (a 1967 spoof starring David Niven) and Never Say Never Again (a 1983 remake of an earlier Eon-produced film, 1965's Thunderball, both starring Connery). In 2015, the series was estimated to be worth $19.9 billion,[1] making James Bond one of the highest-grossing media franchises of all time.~";
            Day1Str obj = new Day1Str();
            obj.words_cnt(str);
            obj.blank_sp_cnt(str);
            obj.digit_cnt(str);
            obj.no_statements(str);
            obj.verb_cnt(str);
            obj.customindex(str);


            Console.WriteLine("\n---------------------------Question 3 & 4-----------------------------");
            EmployeeCollection employees = new EmployeeCollection();

            Console.WriteLine("Print Employee with Second Max Salary");
            var res1 = employees.OrderByDescending(e => e.Salary).Skip(1).Take(1);
            Print(res1);

            Console.WriteLine("Print Employee with Max Salary Per Department");
            var res2 = employees.GroupBy(x => x.DeptName)
                                        .Select(g => g.OrderByDescending(x => x.Salary).First());
            Print(res2);

            Console.WriteLine("Print Employee with Min Salary Per Department");
            var res3 = employees.GroupBy(x => x.DeptName)
                                        .Select(g => g.OrderBy(x => x.Salary).First());

            Print(res3);

            Console.ReadLine();

        }

        static void Printoddlength(String[] names)
        {
            Console.WriteLine("string having odd length\n");
            var x = names.Where(e => e.Length % 2 == 1);
            foreach (var xx in x)
            {
                Console.WriteLine(xx);
            }
        }
        static void Printlengthmorethan7(String[] names)
        {
            Console.WriteLine("String having length >= 7 \n");
            var x = names.Where(e => e.Length >= 7);
            foreach (String name in x)
            {
                Console.WriteLine(name);
            }

        }
        static void PrintStartWith(String[] names, char ch)
        {
            Console.Write($"string starts with a Character {ch} \n");
            var res = names.Where(a => a[0].ToString().ToLower() == ch.ToString().ToLower());
            foreach (var name in res)
            {
                Console.Write($"{name}, ");
            }

        }
        static void PrintContains(String[] names, char ch)
        {
            Console.WriteLine($"string that contain the Character {ch} \n");
            var res = names.Where(e => e.ToLower().Contains(ch.ToString().ToLower()));
            foreach (var name in res)
            {
                Console.Write($"{name}, ");
            }
        }
        static void Print(IEnumerable<Employee> emps)
        {
            foreach (Employee emp in emps)
            {
                Console.WriteLine($"{emp.EmpNo} {emp.EmpName} {emp.Salary} {emp.DeptName}");
            }
        }

    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public int Salary { get; set; }
    }
    public class EmployeeCollection : List<Employee>
    {
        public EmployeeCollection()
        {
            Add(new Employee() { EmpNo = 1001, EmpName = "YashodaNandan", DeptName = "IT", Salary = 53000 });
            Add(new Employee() { EmpNo = 1002, EmpName = "DevkiNandan", DeptName = "CTD", Salary = 33000 });
            Add(new Employee() { EmpNo = 1003, EmpName = "RadheShyam", DeptName = "SYS", Salary = 63000 });
            Add(new Employee() { EmpNo = 1004, EmpName = "Gopal", DeptName = "HRD", Salary = 13000 });
            Add(new Employee() { EmpNo = 1005, EmpName = "Govind", DeptName = "SYS", Salary = 93000 });
            Add(new Employee() { EmpNo = 1006, EmpName = "Mohan", DeptName = "CTD", Salary = 63000 });
            Add(new Employee() { EmpNo = 1007, EmpName = "Madhav", DeptName = "IT", Salary = 23000 });
            Add(new Employee() { EmpNo = 1008, EmpName = "Milind", DeptName = "ACCTS", Salary = 53000 });
            Add(new Employee() { EmpNo = 1009, EmpName = "Vasudev", DeptName = "ACCTS", Salary = 63000 });
            Add(new Employee() { EmpNo = 1010, EmpName = "Shridhar", DeptName = "IT", Salary = 83000 });
        }
    }

    public class Day1Str
    {
        /*public void words_cnt(String str)
        {
            int words_cnt = 0;
            foreach (char ch in str)
            {
                if (ch == ' ') words_cnt++;
            }
            Console.WriteLine($"Total number of words are {words_cnt + 1}");
        }
        public void blank_sp_cnt(String str)
        {
            int blank_sp_cnt = 0;
            foreach (char ch in str)
            {
                if (ch == ' ') blank_sp_cnt++;
            }
            Console.WriteLine($"Total number of blank spaces are {blank_sp_cnt}");
        }
        public void digit_cnt(String str)
        {
            int letter_cnt = 0;
            foreach (char ch in str)
            {
                if (Char.IsLetter(ch)) letter_cnt++;
            }
            Console.WriteLine($"Total number of letters are {letter_cnt}");
        }
        public void sp_char_cnt(String str)
        {
            int i = 0;
            while (str[i] != '~')
            {
                if (!Char.IsLetterOrDigit(str[i]) && str[i] != ' ') Console.WriteLine($"Special character {str[i]} at {i} index");
                i++;
            }
        }
        public void no_statements(String str)
        {
            int state_cnt = 0;
            foreach (char ch in str)
            {
                if (ch == '.') state_cnt++;
            }
            Console.WriteLine($"Total number of statements are {state_cnt}");
        }
        public void customindex(String str)
        {
            List<int> inList = new List<int>();
            List<int> theList = new List<int>();
            List<int> toList = new List<int>();
            List<int> isList = new List<int>();
            List<int> ofList = new List<int>();
            int in_cnt = 0, the_cnt = 0, to_cnt = 0, is_cnt = 0, of_cnt = 0, idx = 0, i;
            for (i = 0; i < str.Length; i++)
            {
                if (str[i] == 'i' && str[i + 1] == 'n')
                {
                    inList.Add(i);
                }
                else if (str[i] == 't' && str[i + 1] == 'h' && str[i + 2] == 'e')
                {
                    theList.Add(i);
                }
                else if (str[i] == 't' && str[i + 1] == 'o')
                {
                    toList.Add(i);
                }
                else if (str[i] == 'i' && str[i + 1] == 's')
                {
                    isList.Add(i);
                }
                else if (str[i] == 'o' && str[i + 1] == 'f')
                {
                    ofList.Add(i);
                }
            }
            Console.WriteLine($"Number of 'in' is {inList.Count}");
            Console.WriteLine($"Number of 'the' is {theList.Count}");
            Console.WriteLine($"Number of 'to' is {toList.Count}");
            Console.WriteLine($"Number of 'is' is {isList.Count}");
            Console.WriteLine($"Number of 'of' is {ofList.Count}");
        }
        public void verb_cnt(String str)
        {
            String[] verbs = { "death", "running", "play", "featured", "published" };
            int i, j, k, cnt = 0;
            for (i = 0; i < str.Length; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    int f = 0;
                    for (k = 0; k < verbs[j].Length; k++)
                    {
                        if (verbs[j][k] != str[i + k])
                        {
                            f = 1;
                            break;
                        }
                    }
                    if (f == 0) cnt++;
                }
            }
            Console.WriteLine($"Number of verbs is {cnt}");
        }*/
    }

    public static class ProgramExt
    {
        public static void words_cnt(this Day1Str abc, String str)
        {
            int words_cnt = 0;
            foreach (char ch in str)
            {
                if (ch == ' ') words_cnt++;
            }
            Console.WriteLine($"Total words: {words_cnt + 1}");
        }

        public static void blank_sp_cnt(this Day1Str abc, String str)
        {
            int blank_sp_cnt = 0;
            foreach (char ch in str)
            {
                if (ch == ' ') blank_sp_cnt++;
            }
            Console.WriteLine($"Total blank spaces : {blank_sp_cnt}");
        }
        public static void digit_cnt(this Day1Str abc, String str)
        {
            int letter_cnt = 0;
            /*foreach (char ch in str)
            {
                if (!Char.IsLetter(ch)) letter_cnt++;
            }*/
            var x = str.Where(e => !Char.IsLetter(e));
            Console.WriteLine($"Total  digits: {x.Count()}");
        }
        public static void sp_char_cnt(this Day1Str abc, String str)
        {
            int i = 0;
            while (str[i] != '~')
            {
                if (!Char.IsLetterOrDigit(str[i]) && str[i] != ' ') Console.WriteLine($"Special character {str[i]} at {i} index");
                i++;
            }
        }
        public static void no_statements(this Day1Str abc, String str)
        {
            int state_cnt = 0, i;
            for (i = 0; i < str.Length; i++)
            {
                if (str[i] == '.' && str[i + 1] == ' ') state_cnt++;
            }
            Console.WriteLine($"Total statements: {state_cnt}");
        }
        public static void customindex(this Day1Str abc, String str)
        {
            List<int> inList = new List<int>();
            List<int> theList = new List<int>();
            List<int> toList = new List<int>();
            List<int> isList = new List<int>();
            List<int> ofList = new List<int>();
            int in_cnt = 0, the_cnt = 0, to_cnt = 0, is_cnt = 0, of_cnt = 0, idx = 0, i;
            for (i = 0; i < str.Length; i++)
            {
                if (str[i] == 'i' && str[i + 1] == 'n')
                {
                    inList.Add(i);
                }
                else if (str[i] == 't' && str[i + 1] == 'h' && str[i + 2] == 'e')
                {
                    theList.Add(i);
                }
                else if (str[i] == 't' && str[i + 1] == 'o')
                {
                    toList.Add(i);
                }
                else if (str[i] == 'i' && str[i + 1] == 's')
                {
                    isList.Add(i);
                }
                else if (str[i] == 'o' && str[i + 1] == 'f')
                {
                    ofList.Add(i);
                }
            }
            Console.WriteLine($"Total no of 'in' are: {inList.Count}");
            Console.WriteLine($"Total no of 'the' are: {theList.Count}");
            Console.WriteLine($"Total no of 'to' are: {toList.Count}");
            Console.WriteLine($"Total no of 'is' are: {isList.Count}");
            Console.WriteLine($"Total no of 'of' are: {ofList.Count}");
        }
        public static void verb_cnt(this Day1Str abc, String str)
        {
            String[] verbs = { "death", "running", "play", "featured", "published" };
            int i, j, k, cnt = 0;
            for (i = 0; i < str.Length; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    int f = 0;
                    for (k = 0; k < verbs[j].Length; k++)
                    {
                        if (verbs[j][k] != str[i + k])
                        {
                            f = 1;
                            break;
                        }
                    }
                    if (f == 0) cnt++;
                }
            }
            Console.WriteLine($"Number of verbs is {cnt}");
        }


    }
}