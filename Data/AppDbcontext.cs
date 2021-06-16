using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using PatrahSave.Models;
using System.Linq;
using System.Threading.Tasks;
using PatrahSave.Controllers;

namespace PatrahSave.Data
{
    public class AppDbcontext :DbContext

    {
        public AppDbcontext(DbContextOptions<AppDbcontext>Option) : base()
        {
            
        }
        public DbSet<Member> Members { get; set; }
     internal IEnumerable<Members> Member { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        // public IEnumerable<Member> Member{ get; internal set; }
        public DbSet<Accounttype> Accounttypes { get; set; }
        protected override void OnModelCreating(ModelBuilder builder) { }
    }
}
