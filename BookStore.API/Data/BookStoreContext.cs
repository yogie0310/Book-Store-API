using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.API.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            :base(options)
        { 

        }

        public DbSet<Books> Books { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=CXS-YOGENDER;Database=BookStoreAPI;Trusted_Connection=True;MultipleActiveResultSets=true;User ID=sa;Password=pass;Persist Security Info=True");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
 