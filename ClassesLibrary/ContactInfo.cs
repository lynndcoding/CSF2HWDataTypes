using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class ContactInfo
    {
        //fields
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;
        private string _phone;
        private string _email;

        //properties
        public string StreetAddress
        {
            get { return _streetAddress; } //is used when you recall information
            set { _streetAddress = value; }//is used when you assign values
        }

        public string City
        {
            get { return _city; } //is used when you recall information
            set { _city = value; }//is used when you assign values
        }

        public string State
        {
            get { return _state; } //is used when you recall information
            set { _state = value; }//is used when you assign values
        }

        public string Zip
        {
            get { return _zip; } //is used when you recall information
            set { _zip = value; }//is used when you assign values
        }

        public string Phone
        {
            get { return _phone; } //is used when you recall information
            set { _phone = value; }//is used when you assign values
        }

        public string Email
        {
            get { return _email; } //is used when you recall information
            set { _email = value; }//is used when you assign values
        }

        //ctor
        /// <summary>
        ///Makes a fully qualified Login object
        /// </summary>
        /// <param name="streetAddress">Street Address</param>
        /// <param name="city">City</param>
        /// <param name="state">State</param>
        /// <param name="zip">Zip</param>
        /// <param name="phone">Phone Number</param>
        /// <param name="email">Email</param>
        public ContactInfo(string streetAddress, string city, string state, string zip, string phone, string email)
        {
            //Property = parameter
            //PascalCase = camelCase
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }//end of Fully Qualified Ctor

        //methods
        public ContactInfo() { } //since we accepted no parameters, we have no work to do in the method

        public override string ToString()
        {
            return string.Format("Street Address: {0}\nCity: {1}\nState: {2}\nZip: {3}\nPhone: {4}\nEmail: {5}", StreetAddress, City, State, Zip, Phone, Email);
        }
    }//end class

}//end namespace


////Method


//public override string ToString()
//{
//    return string.Format($"{CustomerID}\t\t{FirstName} {LastName}\n" +
////$"Phone: {ContactInformation.Phone}\n" +
////$"Email: {ContactInformation.Email}" +
//                                                                                                                             $"{ContactInformation}");
//    return CustomerID;
//}
//ctor

/*ADD TO CONSOLE*/
//static void Main(string[] args)
//{
//    Student s1 = new Student();
//    s1.FirstName = "Han";
//    s1.LastName = "Solo";
//    Console.WriteLine(s1);


//    Vehicle v1 = new Vehicle("Chevrolet", "Bel Air", 1957, 3273);
//    Console.WriteLine(v1);

//    Login log1 = new Login();
//    log1.Userame = "Chewbacca";
//    log1.Password = "Millennium Falcon";
//    Console.WriteLine(log1);

//    ContactInfo c1 = new ContactInfo("P.O. Box 49344", "Los Angles", "California", "90049", "323-461-0100", "NA");
//    Console.WriteLine(c1);

//    Customer cus1 = new Customer("0001", "Harrison", "Ford", c1);
//    Console.WriteLine(cus1);

//    CreditCardAccount cc1 = new CreditCardAccount(1, cus1, 1000m, false, 7);
//    Console.WriteLine(cc1);

//    Book bk1 = new Book("Atlas Shrugged", "Ayn Rand", 1168);
//    Console.WriteLine(bk1);


//    List<Book> books = new List<Book>() { bk1 };

