using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    public class Student
    {
        static void Main(string[] args)
        {
            //public Student(string firstName, string lastName, string id, float gpa)
            Console.WriteLine("----------STUDENT INFORMATION----------");
            ClassesLibrary.Student s1 = new ClassesLibrary.Student();         //CONSTRUCTOR METHOD
            s1.FirstName = "Harry";
            s1.LastName = "Potter";
            s1.Id = "001";
            s1.Gpa = 3;
            ClassesLibrary.Student s2 = new ClassesLibrary.Student();         //CONSTRUCTOR METHOD
            s2.FirstName = "Hermione";
            s2.LastName = "Grainger";
            s2.Id = "002";
            s2.Gpa = 4;
            ClassesLibrary.Student s3 = new ClassesLibrary.Student();         //CONSTRUCTOR METHOD
            s3.FirstName = "Ronald";
            s3.LastName = "Weasley";
            s3.Id = "003";
            s3.Gpa = 2;
            Console.WriteLine("\nUsing the Constructor Method, the names of our students are");
            Console.WriteLine($"First Name: { s1.FirstName} Last Name: {s1.LastName} ID: {s1.Id}  GPA: {s1.Gpa}");
            Console.WriteLine($"First Name: { s2.FirstName} Last Name: {s2.LastName} ID: {s2.Id}  GPA: {s2.Gpa}");
            Console.WriteLine($"First Name: { s3.FirstName} Last Name: {s3.LastName} ID: {s3.Id}  GPA: {s3.Gpa}");

            //---------using the ToString()
            Console.WriteLine("\nUsing the ToString Method:");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            Console.WriteLine("----------VEHICLE INFORMATION----------");
        }//end Main()
    }//end class
}//end namespace
