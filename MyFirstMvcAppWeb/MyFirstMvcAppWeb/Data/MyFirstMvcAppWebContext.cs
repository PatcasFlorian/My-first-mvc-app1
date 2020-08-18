using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFirstMvcAppWeb.Models;

namespace MyFirstMvcAppWeb.Data
{
    public class MyFirstMvcAppWebContext : DbContext
    {
        public MyFirstMvcAppWebContext (DbContextOptions<MyFirstMvcAppWebContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstMvcAppWeb.Models.ContactListEntry> ContactListEntry { get; set; }
    }
}
