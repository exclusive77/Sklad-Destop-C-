using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_alef1.Model
{
    class MyDbContext:DbContext

    {public MyDbContext() : base("DefaultConnection") { }
        public DbSet <Users> Users { get; set; }
        public DbSet<Emps> Employees { get; set; }
        public DbSet <Prods> Product { get; set; }
        public DbSet<Exp> ExpOrder { get; set; }
        public DbSet<ExpD> ExpDetalsOrder { get; set; }
    }
}
