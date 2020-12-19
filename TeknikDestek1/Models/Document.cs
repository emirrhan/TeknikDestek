using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeknikDestek1.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string DocumentName { get; set; }//DÖKÜMAN İSMİ
        public int? DocumentDate { get; set; }//TARİH

        public string DocumentSubject { get; set; }//KONUSU
        public string DocumentInfo { get; set; }//NASIL YAPILIR TARİF KISMI

        public string DocumentBanner { get; set; }//AFİŞİ

        public string DocumentVideo { get; set; }//VİDEO LİNKİ
        public string References { get; set; }
        public int WriterId { get; set; }//YAZAR

        public int? CategoryId { get; set; }//bu olmasada oluşturur bu kısım (veri tabanında oluşacak kısım)
        public Category Category { get; set; }//kategoriden kalıtım alıyoruz
        public Writer Writer { get; set; }
    }
}
