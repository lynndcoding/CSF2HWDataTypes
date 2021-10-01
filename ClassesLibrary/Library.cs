using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {
        //fields
        private string _libraryName;
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;

        //properties
        public List<Book> Books { get; set; }
        public string LibraryName
        {
            get { return _libraryName; } //is used when you recall information
            set { _libraryName = value; }//is used when you assign values
        }
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

        //ctor
        /// <summary>
        /// Makes a fully qualified Book object
        /// </summary>
        /// <param name="title">Title of Book</param>
        /// <param name="author">Author of Book</param>
        /// <param name="numberPages">Number of pages in book</param>
        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            //Property = parameter
            //PascalCase = camelCase
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }//end of Fully Qualified Ctor

        //method
        public Library() { } //since we accepted no parameters, we have no work to do in the method

        public override string ToString()
        {
            return string.Format($"Books: {Books} " +
                $"Library Name: {LibraryName} " +
                $"Street Address: {StreetAddress}" +
                $"City: {City}" +
                $"State: {State}" +
                $"Zip: {Zip}");
        }
    }//end class
}//end namespace
