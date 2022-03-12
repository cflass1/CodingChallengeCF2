using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodingChallengeCF2.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConn")
        {

        }

        public DbSet<Thing> Things { get; set; }
    
    }
}
