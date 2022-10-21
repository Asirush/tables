using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables.dll
{
    public class EntityDbContext: DbContext
    {
        public EntityDbContext() :base("ConnectionStrings") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Desc> Descs { get; set; }
        public DbSet<JobTitle> JobTitle { get; set; }
    }
}