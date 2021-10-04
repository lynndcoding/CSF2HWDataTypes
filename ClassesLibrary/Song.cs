using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Song
    {
        //fields
        private string _artist;
        private string _title;
        private int _lengthInSeconds;

        //properties
        public string Artist
        {
            get { return _artist; } //is used when you recall information
            set { _artist = value; }//is used when you assign values
        }
        public string Title
        {
            get { return _title; } //is used when you recall information
            set { _title = value; }//is used when you assign values
        }

        public int LengthInSeconds
        {
            get { return _lengthInSeconds; } //is used when you recall information
            set { _lengthInSeconds = value; }//is used when you assign values
        }

        //ctor
        public Song(string artist, string title, int lengthInSeconds)
        {
            //Property = parameter
            //PascalCase = camelCase
            Artist = artist;
            Title = title;
            LengthInSeconds = lengthInSeconds;
        }//end of Fully Qualified Ctor

        //methods
        public Song() { } //since we accepted no parameters, we have no work to do in the method

        public override string ToString()
        {
            return string.Format("Artist: {0}Title: {1} Length in Seconds: {2}", Artist, Title, LengthInSeconds);
        }
    }//end class
}//end namespace

