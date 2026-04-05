using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementReviewQues
{
    internal class Book
    {
        private string Title;
        private string Author;
        private string Status;
        
        public string _Title
        {
            get {  return Title; }
            set { Title = value; }
        }
        public string _Author
        {
            get { return Author; }
            set { Author = value; }
        }
        public string _Status
        {
            get { return Status; }
            set { Status = value; }
        }
        public Book(string title, string author, string status)
        {
            Title = title;
            Author = author;
            Status = status;
        }
        public override string ToString()
        {
            return ($"Title : {_Title} Author : {_Author} Status : {_Status}");
        }
    }
}
