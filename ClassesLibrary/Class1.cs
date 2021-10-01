using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Student
    {
        //fields
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        //properties
        public string FirstName
        {
            get { return _firstName; } //is used when you recall information
            set { _firstName = value; }//is used when you assign values
        }

        public string LastName
        {
            get { return _lastName; } //is used when you recall information
            set { _lastName = value; }//is used when you assign values
        }

        public string Id
        {
            get { return _id; } //is used when you recall information
            set { _id = value; }//is used when you assign values
        }

        public float Gpa
        {
            get { return _gpa; } //is used when you recall information
            set { _gpa = value; }//is used when you assign values
        }

        //ctor
        public Student(string firstName, string lastName, string id, float gpa)
        {
            //Property = parameter
            //PascalCase = camelCase
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Gpa = gpa;
        }//end of Fully Qualified Ctor

        //methods
        public Student() { } //since we accepted no parameters, we have no work to do in the method

        public override string ToString()
        {
            return string.Format("FirstName: {0}LastName: {1} ID: {2} GPA: {3}", FirstName, LastName, Id, Gpa);
        }
    }//end class

    public class Vehicle
        {
            //fields
            private string _make;
            private string _model;
            private int _year;
            private float _weight;

            //properties
            public string Make
            {
                get { return _make; } //is used when you recall information
                set { _make = value; }//is used when you assign values
            }

            public string Model
            {
                get { return _model; } //is used when you recall information
                set { _model = value; }//is used when you assign values
            }

            public int Year
            {
                get { return _year; } //is used when you recall information
                set { _year = value; }//is used when you assign values
            }

            public float Weight
            {
                get { return _weight; } //is used when you recall information
                set { _weight = value; }//is used when you assign values
            }

            //ctor
            public Vehicle(string make, string model, int year, float weight)
            {
                //Property = parameter
                //PascalCase = camelCase
                Make = make;
                Model = model;
                Year = year;
                Weight = weight;

            }//end of Fully Qualified Ctor

            //methods
            public Vehicle() { } //since we accepted no parameters, we have no work to do in the method

            public override string ToString()
            {
                return string.Format("Make: {0}Model: {1} Year: {2} Weight: {3}", Make, Model, Year, Weight);
            }
        }//end class

        public class Login
        {
            //fields
            private string _userName;
            private string _password;

            //properties
            public string UserName
            {
                get { return _userName; } //is used when you recall information
                set { _userName = value; }//is used when you assign values
            }

            public string Password
            {
                get { return _password; } //is used when you recall information
                set { _password = value; }//is used when you assign values
            }

            //ctor
            public Login(string userName, string password)
            {
                //Property = parameter
                //PascalCase = camelCase
                UserName = userName;
                Password = password;
            }//end of Fully Qualified Ctor

            //methods
            public Login() { } //since we accepted no parameters, we have no work to do in the method

            public override string ToString()
            {
                return string.Format("UserName: {0}\nPassword: {1}\n", UserName, Password);
            }
        }//end class

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
                return string.Format("Street Address: {0}\nCity: {1}\nState: {2}\n Zip: {3}\nPhone: {4}\n Email: {5}", StreetAddress, City, State, Zip, Phone, Email);
            }
        }//end class

    }//end namespace
