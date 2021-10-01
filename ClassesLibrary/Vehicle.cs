using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
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
}
