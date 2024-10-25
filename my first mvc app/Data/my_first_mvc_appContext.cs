using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using my_first_mvc_app.Models;

namespace my_first_mvc_app.Data
{
    public class my_first_mvc_appContext : DbContext
    {
        public my_first_mvc_appContext (DbContextOptions<my_first_mvc_appContext> options)
            : base(options)
        {
        }

        public DbSet<my_first_mvc_app.Models.Product> Product { get; set; } = default!;
    }
}
