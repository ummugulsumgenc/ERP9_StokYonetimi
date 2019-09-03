using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Sy.Core.Entities;

namespace sy.DataAccess
{
    public class StokDbContext : DbContext
    {
        public StokDbContext()
            : base(nameOrConnectionString: "name=MyCon")
        {
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
    }
}

