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

