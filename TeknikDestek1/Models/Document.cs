using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeknikDestek1.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string DocumentName { get; set; }
        public int? DocumentDate { get; set; }

        public string DocumentSubject { get; set; }

        public string DocumentBanner { get; set; }

        public string DocumentVideo { get; set; }
        public int WriterId { get; set; }

        public int CategoryId { get; set; }//bu olmasada oluşturur bu kısım (veri tabanında oluşacak kısım)
        public Category Category { get; set; }//kategoriden kalıtım alıyoruz
        public Writer Writer { get; set; }
    }
}
