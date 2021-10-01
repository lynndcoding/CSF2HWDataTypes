using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
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

        //make a FQ ctor
        /// <summary>
        /// Makes a fully qualified Login object
        /// </summary>
        /// <param name="userName">A unique User Name</param>
        /// <param name="password">A unique password</param>

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
}

