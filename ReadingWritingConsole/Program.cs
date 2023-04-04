using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingWritingConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"1st answer:");
            string EmpName = "Somen Singh";

            Console.WriteLine("*********");

            Console.WriteLine($"{EmpName}");
            Console.WriteLine($"\n 2nd answer:");
            string SchoolName = "Holy Cross School";
            Console.WriteLine($"School name is {SchoolName}");

            Console.WriteLine("*********");

            Console.WriteLine($"\n 3rd answer:");
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");

            Console.WriteLine("*********");
            Console.WriteLine($"\n 4th answer: concatenation: ");
            Console.WriteLine("Enter first name:");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lname = Console.ReadLine();
            Console.WriteLine($"Hello {fname} {lname}!");

            Console.WriteLine("*********");

            Console.WriteLine($"\n 5th answer: concatenation: ");
            Console.WriteLine("Enter password:");
            string pswd = Console.ReadLine();
            char[] pswdArray = pswd.ToCharArray();

            for( int i =0; i < pswdArray.Length; i++)
            {
                Console.Write(pswdArray[i]);
            }
           
            Console.Read();
        }
    }
}
