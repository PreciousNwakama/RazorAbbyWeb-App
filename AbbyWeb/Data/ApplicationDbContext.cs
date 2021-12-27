using AbbyWeb.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbbyWeb.Data
{
    //Defined inside the EntityFrameworkCore to access and manage the database
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //create DbSet for all the table we have in our database
        //Database name is Category
        public DbSet<Category> Category { get; set; }
    }
}
