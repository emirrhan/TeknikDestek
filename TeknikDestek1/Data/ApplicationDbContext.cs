using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeknikDestek1.Models;

namespace TeknikDestek1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        //veri tabanına tablo oluşturma kısmı
        public DbSet<Document> Document { get; set; }

        public DbSet<Category> Category { get; set; }
        public DbSet<Writer> Writer { get; set; }
    }
}
