using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace S4_PC1_Lab.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<S4_PC1_Lab.Models.Producto> DataProductos { get; set; }





    }
}