using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoGo.Entities;
using Microsoft.EntityFrameworkCore;

namespace LoGo.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options){

        }
        public DbSet<Logo> Logos { get; set; }
    }
}