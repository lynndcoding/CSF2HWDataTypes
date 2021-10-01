using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //public Student(string firstName, string lastName, string id, float gpa)
            Console.WriteLine("----------STUDENT INFORMATION----------");
            Student s1 = new Student();         //CONSTRUCTOR METHOD
            s1.FirstName = "Harry";
            s1.LastName = "Potter";
            s1.Id = "001";
            s1.Gpa = 3;
            Student s2 = new Student();         //CONSTRUCTOR METHOD
            s2.FirstName = "Hermione";
            s2.LastName = "Grainger";
            s2.Id = "002";
            s2.Gpa = 4;
            Student s3 = new Student();         //CONSTRUCTOR METHOD
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

            //public Vehicle(string make, string model, int year, float weight)

            Vehicle v1 = new Vehicle();         //CONSTRUCTOR METHOD
            v1.Make = "Chevy";
            v1.Model = "Impala";
            v1.Year = 1968;
            v1.Weight = 200;
            Console.WriteLine("\nUsing the Constructor Method:");
            Console.WriteLine($"Make: { v1.Make} Last Name: {v1.Model} ID: {v1.Year}  GPA: {v1.Weight}");

            //---------using the ToString()
            Console.WriteLine("\nUsing the ToString Method:");
            Console.WriteLine(v1);

            Console.WriteLine("----------LOGIN INFORMATION----------");

            //public Student(string firstName, string lastName, string id, float gpa)

            Login l1 = new Login();         //CONSTRUCTOR METHOD
            l1.UserName = "Disdude";
            l1.Password = "123";
            Console.WriteLine("\nUsing the Constructor Method:");
            Console.WriteLine($"User Name: { l1.UserName} Password: {l1.Password} ");

            //---------using the ToString()
            Console.WriteLine("\nUsing the ToString Method:");
            Console.WriteLine(l1);
        }//end Main()
    }//end class
}//end namespace