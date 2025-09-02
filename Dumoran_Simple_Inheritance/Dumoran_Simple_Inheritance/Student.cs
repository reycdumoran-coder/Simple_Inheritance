using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumoran_Simple_Inheritance
{
    internal class Student
    {
        //property student name
        public string Name { get; set; }
        //property to store the student program 
        public string Program { get; set; }
        
        //method to display basic information to student
        public void BasicInfo() 
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Program: " + Program);
        }
      
    }
    //derived class of regular student
    class RegularStudent : Student 
    {//property display the section of student
        public string Section { get; set; }

        //method
        public void SectionEnrolled() 
        {
            Console.WriteLine("Section: " + Section);
            Console.WriteLine();
        }
    }
    //derived class of irregular student
    class IrregularStudent : Student
    {
        //property to display if what units enrolled
        public int UnitsEnrolled { get; set; }

        //method
        public void EnrolledSemUnits()
        {
            Console.WriteLine("UnitsEnrolled: " + UnitsEnrolled);
            Console.WriteLine();
        }


    }
    

}
