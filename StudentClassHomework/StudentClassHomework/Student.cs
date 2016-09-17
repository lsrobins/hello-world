using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassHomework
{
    class Student
    {
        // Class variables
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String address { get; set; }
        public String state { get; set; }
        public String zipCode { get; set; }

        // Constructor
        public Student()
        {

        }

        // Command to return all of a students info
        public void getInfo()
        {
            String info = "\nStudent info: \n"
                        +     "    " + firstName + " " + lastName + "\n"
                        +     "    " + address + "\n"
                        +     "    " + state + ", " + zipCode;
            Console.WriteLine("\n");
            Console.WriteLine(info);    
        }
    }
}
