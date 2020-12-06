using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeknikDestek1.Models
{
    public class Writer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public Cinsiyet Cinsiyet { get; set; }


    }

    public enum Cinsiyet
    {
        Erkek=1,
        Kadin=2
    }
}
