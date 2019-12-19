using Microsoft.EntityFrameworkCore;
using Secret_Santa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secret_Santa
{
    public class SomeContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-BP3JMTE;Database=SS;Integrated Security=True;");
        }
    }
}
