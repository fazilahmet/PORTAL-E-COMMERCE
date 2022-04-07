using E_Ticaret.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret_Net_Project
{

    public class DbPgContext : DbContext
    {
        public DbPgContext(DbContextOptions<DbPgContext> options) : base(options)
        {

        }
        public DbSet<Kullanici> Kullanicis { get; set; }
  

    }
   
}
