using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumoran_Simple_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name:Dumoran,Rey C.
            //Section:BSIT-301
            //Exer: Simple Inheritance

            
            RegularStudent regularStudent = new RegularStudent();
            //Set the Student name
            regularStudent.Name = "Rey";
            //Set the program to student to enrolled
            regularStudent.Program = "BSIT";
            //set the section to student to belongs to
            regularStudent.Section = "IT-301";
            //Display basic information to regular student
            regularStudent.BasicInfo();
            regularStudent.SectionEnrolled();

            IrregularStudent irregularStudent = new IrregularStudent();
            //Set the Student name
            irregularStudent.Name = "John";
            //set the section to student to belongs to
            irregularStudent.Program = "BSHM";
            //set the units if the student is irregular
            irregularStudent.UnitsEnrolled = 18;
            //Display basic information to regular student
            irregularStudent.BasicInfo();
            irregularStudent.EnrolledSemUnits();

            Console.ReadLine();



        }
    }
}
