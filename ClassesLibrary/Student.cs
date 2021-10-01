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
}
