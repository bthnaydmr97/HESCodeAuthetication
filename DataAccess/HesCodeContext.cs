using Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    // Db tabloları ile proje classlarına bağlamak.
    public class HesCodeContext : DbContext
    {
        // Created Database on my local
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-LNTHMCF\SQLEXPRESS;Database=HesCodeDB;Integrated Security=SSPI");
        }

        // Created TableName on  my DataBase
        public DbSet<HesCode> HesCodes { get; set; }
    }
}
