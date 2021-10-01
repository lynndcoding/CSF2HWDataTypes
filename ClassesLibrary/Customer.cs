using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        //fields
        private string _customerId;
        private string _firstName;
        private string _lastName;
        private float _gpa;

        //properties
        public string CustomerId
        {
            get { return _customerId; } //is used when you recall information
            set { _customerId = value; }//is used when you assign values
        }
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

        //TODO: Add contactInformation from DLL ContactInfo
        public ContactInfo contactInfo { get; set; }  //not sure if this is going to work???
        //make a FQ ctor
        /// <summary>
        /// Makes a fully qualified Customer object
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="contactInfo"></param>

        //ctor
        public Customer(string customerId, string firstName, string lastName, string contactInfo)
        {
            //Property = parameter
            //PascalCase = camelCase
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            //ContactInfo.ContactInfo = contactInfo;        <<<---NEED ANOTHER EXAMPLE HOW TO DO THIS

        }//end of Fully Qualified Ctor

        //methods
        public Customer() { } //since we accepted no parameters, we have no work to do in the method

        public override string ToString()
        {
            return string.Format($"Customer ID: {CustomerId} First Name: {FirstName} Last Name: {LastName} Contact Info: {contactInfo}");
        }

        //public static string CustomerInfo()
        //{
        //    return string.Format($"Customer ID: {Customer.CustomerId} First Name: {FirstName} Last Name: {LastName} Contact Info: {contactInfo}");
        //}
    }//end class
}//end namespace