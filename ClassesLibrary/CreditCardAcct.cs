using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAcct

    {
        //fields
        private int _accountNo;
        private decimal _balance;
        private bool _isPastDue;
        private decimal _annualIntRate;

        //properties
        public int AccountNo
        {
            get { return _accountNo; } //is used when you recall information
            set { _accountNo = value; }//is used when you assign values
        }
        public decimal Balance
        {
            get { return _balance; } //is used when you recall information
            set { _balance = value; }//is used when you assign values
        }

        public bool IsPastDue
        {
            get { return _isPastDue; } //is used when you recall information
            set { _isPastDue = value; }//is used when you assign values
        }

        public decimal AnnualIntRate
        {
            get { return _annualIntRate; }
            set { _annualIntRate = value; }
        }
        //TODO: Add contactInformation from DLL ContactInfo
        public Customer customerInfo { get; set; }  //not sure if this is going to work???


        /// <summary>
        /// Makes a fully qualified CreditCardAcct object
        /// </summary>
        /// <param name="accountNo">The account number</param>
        /// <param name="customerInfo">Customer information</param>
        /// <param name="balance">Credit Card Balance</param>
        /// <param name="isPastDue">Is Account past due T/F?</param>
        /// <param name="annualIntRate">Annual Interest Rate</param>
        //ctor
        public CreditCardAcct(int accountNo, string customerInfo, decimal balance, bool isPastDue, decimal annualIntRate)
        {
            //Property = parameter
            //PascalCase = camelCase
            AccountNo = accountNo;
            //CustomerInfo = customerInfo
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualIntRate = annualIntRate;

            //ContactInfo.ContactInfo = contactInfo;        <<<---NEED ANOTHER EXAMPLE HOW TO DO THIS

        }//end of Fully Qualified Ctor

        //methods
        public CreditCardAcct() { } //since we accepted no parameters, we have no work to do in the method

        public override string ToString()
        {
            return string.Format($"Account No.: {AccountNo} Customer Info: {customerInfo} Card Balance: {Balance:c} Is payment past due: {IsPastDue} Annual Interest Rate: {AnnualIntRate}");
        }
    }//end class
}//end namespace