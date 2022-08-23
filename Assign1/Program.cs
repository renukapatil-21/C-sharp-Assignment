using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assign1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------String-------- ");
            string str = "The James Bond series focuses on a fictional British Secret Service agent created in 1953 by writer Ian Fleming, who featured him in twelve novels and two short-story collections. Since Fleming's death in 1964, eight other authors have written authorised Bond novels or novelisations: Kingsley Amis, Christopher Wood, John Gardner, Raymond Benson, Sebastian Faulks, Jeffery Deaver, William Boyd, and Anthony Horowitz. The latest novel is Forever and a Day by Anthony Horowitz, published in May 2018. Additionally Charlie Higson wrote a series on a young James Bond, and Kate Westbrook wrote three novels based on the diaries of a recurring series character, Moneypenny. The character—also known by the code number 007(pronounced \"double-O-seven\")—has also been adapted for television, radio, comic strip, video games and film.The films are one of the longest continually running film series and have grossed over US$7.04 billion in total, making it the fifth - highest - grossing film series to date, which started in 1962 with Dr.No, starring Sean Connery as Bond.As of 2021, there have been twenty - five films in the Eon Productions series.The most recent Bond film, No Time to Die(2021), stars Daniel Craig in his fifth portrayal of Bond; he is the sixth actor to play Bond in the Eon series.There have also been two independent productions of Bond films: Casino Royale(a 1967 spoof starring David Niven) and Never Say Never Again(a 1983 remake of an earlier Eon - produced film, 1965's Thunderball, both starring Connery). In 2015, the series was estimated to be worth $19.9 billion,[1] making James Bond one of the highest-grossing media franchises of all time.";
  
            wordsCount(str);
            blankCount(str);
            digitCount(str);
            verbCount(str);
            indexCount(str);
            statementCount(str);
            splCharCount(str);

            Console.WriteLine("\n--------Array-------- ");
            string[] names = new string[] { "Ram", "Shankar", "Ramesh", "Vivek", "Satish", "Mukesh", "Sandeep", "Vinay", "Mahesh", "Tushar", "Tejas", "Suprotim", "Vikram", "Subodh", "Pravin", "Amit", "Ajit", "Anhijit", "Sharad", "Sanjay", "Vijay", "Abhay", "Vilas", "Anil", "Nandu", "Jaywant", "Shyam" };

            lengretseven(names);
            oddlen(names);
            charContain(names);
            startWith(names);

            Console.ReadLine();
        }
        static void wordsCount(string s)
        {
            int count=0;


            int wordCount = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == ' ' && Char.IsLetter(s[i + 1]) && (i > 0))
                {
                    wordCount++;
                }
            }
            Console.WriteLine($"Print Words Count: {wordCount}" );
        }
        static void blankCount(string str)
        {
            int count=0;
            foreach(char c in str)
            {
                if (char.IsWhiteSpace(c))
                {
                    count++;
                }
            }
            Console.WriteLine($"Print BlankSpace Count: {count}");
        }
        static void digitCount(string str)
        {
            int count = 0;
            foreach(char c in str)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            Console.WriteLine($"Print Digit Count: {count}");
        }
        static void verbCount(string str)
        {
            string[] refarr = { "featured", "death", "wrote", "adapted", "started" };
            int i, j, k, cnt = 0;
            for (i = 0; i < str.Length; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    int f = 0;
                    for (k = 0; k < refarr[j].Length; k++)
                    {
                        if (refarr[j][k] != str[i + k])
                        {
                            f = 1;
                            break;
                        }
                    }
                    if (f == 0) cnt++;
                }
            }
            Console.WriteLine($"Print Adverb Count: {cnt}");
        }
        static void indexCount(String str)
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
        static void statementCount(string str)
        {
            int count = 0;

            foreach(char c in str)
            {
                if(c == '.')
                {
                    count++;
                }
            }
            Console.WriteLine($"Print no. of statements: {count}");
        }
        static void splCharCount(string str)
        {
            int i = 0;
            foreach (char c in str)
            {
                if (!Char.IsDigit(c) && !Char.IsLetter(c) && c != ' ')
                    Console.WriteLine($"spl char: {c} index: {i}");
                i++;
            }
        }

        static void lengretseven(string[] arr)
        {
            foreach(string str in arr)
            {
                if (str.Length > 7)
                {
                    Console.WriteLine($"Print all String having length >= 7: {str} ");
                }
            }
        }
        static void startWith(string[] arr)
        {
            Console.Write("Names startwith: ");
            string str = Console.ReadLine();
            Console.Write($"Names startwith {str} are: ");
            foreach (string s in arr)
            {
                if (s.StartsWith(str) == true)
                {
                    Console.Write($"{s}, ");
                }
            }
        }
        static void oddlen(string[] arr)
        {
            Console.Write($"Print all String having odd length: ");
            foreach (string str in arr)
            {
                if (str.Length % 2 != 0)
                {
                    Console.Write($"{str}, ");
                }
            }
            Console.WriteLine();
        }
        static void charContain(string[] arr)
        {
            Console.Write("Names Contains char: ");
            string str = Console.ReadLine();
            Console.Write($"Names contains {str} are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains(str) == true)
                {
                    Console.Write(arr[i]+", ");
                }
            }
            Console.WriteLine();
        }







    }


}
