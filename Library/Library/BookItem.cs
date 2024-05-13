using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   class BookItem : Book
    {
        public string barcode { get; set; }
        public int tag { get; set; }
        public string isReferenceOnly { get; set; }
        public int CatalogID { get; set; }
        public string AuthorName { get; set; }
        public int? PatronID { get; set; }   
        public int LibraryID { get; set; }
    }
}
