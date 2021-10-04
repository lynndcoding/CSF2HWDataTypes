using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer : ContactInfo
    {
        //fields
        private string _customerId;
        private string _firstName;
        private string _lastName;

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

        //Add contactInformation from DLL ContactInfo
        public ContactInfo ContactInfo { get; set; }  
        //make a FQ ctor
        /// <summary>
        /// Makes a fully qualified Customer object
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="contactInfo"></param>

        //ctor
        public Customer(string customerId, string firstName, string lastName, 
            ContactInfo contactInfo)
        {
            //Property = parameter
            //PascalCase = camelCase
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            ContactInfo = contactInfo;
        }//end of Fully Qualified Ctor

        //methods
        public Customer() { } //since we accepted no parameters, we have no work to do in the method

        public override string ToString()
        {
            return string.Format("\nContact Info: " + ContactInfo);
            //return string.Format($"Customer ID: {CustomerId} First Name: {FirstName} Last Name: {LastName} " +
              //  $"\n\nContact Info: "  {(ContactInfo)};  //TODO: <<<-----NEED HELP HERE!!!!

        }

        //public static string CustomerInfo()
        //{
        //    return string.Format($"Customer ID: {Customer.CustomerId} First Name: {FirstName} Last Name: {LastName} Contact Info: {contactInfo}");
        //}
    }//end class
}//end namespace

/*CODE FOR DLL*/
////Field
////Prop

//public string CustomerID { get; set; }
//public string FirstName { get; set; }
//public string LastName { get; set; }
//public ContactInfo ContactInformation { get; set; }


////Ctor


//public Customer(string customerID, string firstName, string lastName, ContactInfo contactInformation)
//{
//    CustomerID = customerID;
//    FirstName = firstName;
//    LastName = lastName;
//    ContactInformation = contactInformation;
//}