using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TeknikDestek1.Models
{
    public class User :IdentityUser
    {
        public string NameUser { get; set; }

        public string LastNameUser { get; set; }
        public DateTime DtimeUser { get; set; }

    }
}
