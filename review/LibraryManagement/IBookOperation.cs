using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementReviewQues
{
    internal interface IBookOperation
    {
        void AddBook();
        void SearchBook();
        void ChangeStatus();
        void DisplayBooks();
    }
}
