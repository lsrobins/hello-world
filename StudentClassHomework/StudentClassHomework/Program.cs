using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassHomework
{
    class Program
    {

        static void Main(string[] args)
        {
            // Create new student object
            Student s1 = new Student();

            // Aquire student information via console I/O

            Console.WriteLine("Please enter studnet information. \n ");
            Console.Write("First name: ");
            s1.firstName = Console.ReadLine();

            Console.Write("Last name: ");
            s1.lastName = Console.ReadLine();

            Console.Write("Address: ");
            s1.address = Console.ReadLine();

            Console.Write("State: ");
            s1.state = Console.ReadLine();

            Console.Write("Zip Code: ");
            s1.zipCode = Console.ReadLine();

            // Return student information to console via Student.getInfo() method
            s1.getInfo();

            Console.ReadLine();
        }
    }
}
