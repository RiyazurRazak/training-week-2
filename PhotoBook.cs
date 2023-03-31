using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{

   
    public class PhotoBook
    {
        private int totalPages = 0;
        public PhotoBook() {
            this.totalPages = 16;
        }

        public PhotoBook(int noOfPages)
        {
            this.totalPages = noOfPages;
        }

        public int GetNumberOfPages()
        {
            return this.totalPages;
        }
    }
    public class AddPhotoBook : PhotoBook
    {
        public AddPhotoBook() : base(64) { }

    }
}
