using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        //fields
        //We will only be using auto prop syntax, so no fields need to be created
        //The fields will be generated at runtime by .NET

        //properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberPages { get; set; }

        //ctor
        /// <summary>
        /// Makes a fully qualified Book object
        /// </summary>
        /// <param name="title">Title of Book</param>
        /// <param name="author">Author of Book</param>
        /// <param name="numberPages">Number of pages in book</param>
        public Book(string title, string author, int numberPages)
        {
            //Property = parameter
            //PascalCase = camelCase
            Title = title;
            Author = author;
            NumberPages = numberPages;

        }//end of Fully Qualified Ctor

        //method
        public Book() { } //since we accepted no parameters, we have no work to do in the method

        public override string ToString()
        {
            return string.Format($"Title: {Title} Author: {Author} No. of pages: {NumberPages} ");
        }
    }//end class
}//end namespace
