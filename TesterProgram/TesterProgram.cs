using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class TesterProgram
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

            Console.WriteLine("----------CONTACT INFORMATION----------");

            //public ContactInfo(string streetAddress, string city, string state, string zip, string phone, string email)

            ContactInfo c1 = new ContactInfo();         //CONSTRUCTOR METHOD
            c1.StreetAddress = "3421 NW Jefferson Street";
            c1.City = "Blue Springs ";
            c1.State = "MO-Missouri ";
            c1.Zip = "12345 ";
            c1.Phone = "123-456-7890 ";
            c1.Email = "me@gmail.com";

            Console.WriteLine("Using the Constructor Method:");
            Console.WriteLine($"\n" +
                $"Street Address: {c1.StreetAddress} " +
                $"City: {c1.City} " +
                $"State: {c1.State} " +
                $"Zip: {c1.Zip} " +
                $"Phone: {c1.Phone} " +
                $"Email: {c1.Email} ");

            //---------using the ToString()
            Console.WriteLine("\nUsing the ToString Method:");
            Console.WriteLine(c1);

            Console.WriteLine("----------CUSTOMER INFORMATION----------");

            Customer h1 = new Customer();         //CONSTRUCTOR METHOD
            h1.FirstName = "Han";
            h1.LastName = "Solo";
            h1.CustomerId = "123";
            //h1.contactInfo = ContactInfo(City); "Not really sure how this pulls";

            Console.WriteLine("Using the Constructor Method:");
            Console.WriteLine($"\n" +
                $"First Name: {h1.FirstName} " +
                $"Last Name: {h1.LastName} " +
                $"Customer ID: {h1.CustomerId} " +
                $"Contact Info:"); //TODO {h1.ContactInfo.} 

            //---------using the ToString()
            Console.WriteLine("\nUsing the ToString Method:");
            Console.WriteLine(h1);


            Console.WriteLine("----------CREDIT CARD ACCOUNT INFORMATION----------");

            CreditCardAcct a1 = new CreditCardAcct();         //CONSTRUCTOR METHOD
            a1.AccountNo = 123;
            //TODO Figure this out!!
            //a1.customerInfo = Customer(phone);        <<<------NEED HELP WITH THIS ONE
            a1.Balance = 5000;
            a1.IsPastDue = false;
            a1.AnnualIntRate = 5;

            Console.WriteLine("Using the Constructor Method:");
            Console.WriteLine($"\n" +
                $"Account Number: {a1.AccountNo} " +
                $"Customer Info: {h1} " +
                $"Balance: {a1.Balance:c} " +
                $"Is Payment Past Due: {a1.IsPastDue}" +
                $"Annual Interest Rate: {a1.AnnualIntRate}"); //TODO {h1.ContactInfo.} 

            //DisplayReturnPolicy static method which is called from ClassName.MethodName()
            Console.WriteLine("CUSTOMER INFO:\n" + (h1));

            //---------using the ToString()
            Console.WriteLine("\nUsing the ToString Method:");
            Console.WriteLine(a1);

            Console.WriteLine("----------BOOK INFORMATION----------");

            Book b1 = new Book();         //CONSTRUCTOR METHOD
            b1.Author = "Charles Dickens";
            b1.Title = "Bleak House";
            b1.NumberPages = 3458;

            Console.WriteLine("Using the Constructor Method:");
            Console.WriteLine($"\n" +
                $"Author: {b1.Author} " +
                $"Title: {b1.Title} " +
                $"Number of Pages: {b1.NumberPages} "); 

            //---------using the ToString()
            Console.WriteLine("\nUsing the ToString Method:");
            Console.WriteLine(b1);

            Console.WriteLine("----------LIBRARY INFORMATION----------");

            Library r1 = new Library();
            //r1.Books = string b1.Title);      //CONSTRUCTOR METHOD
            r1.LibraryName = "University Library";
            r1.StreetAddress = "123 Street";
            r1.City = "Any City";
            r1.State = "Any State";
            r1.Zip = "12345";

            Console.WriteLine("Using the Constructor Method:");
            Console.WriteLine($"\n" +
                $"Books: {b1.Title} " +
                $"Library Name: {r1.LibraryName} " +
                $"Street Address: {r1.StreetAddress} " +
                $"City: {r1.City} " +
                $"State: {r1.State} " +
                $"Zip: {r1.Zip} ");

            //---------using the ToString()
            Console.WriteLine("\nUsing the ToString Method:");
            Console.WriteLine(r1);


        }//end Main()
    }//end class
}//end namespace