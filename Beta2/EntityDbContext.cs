using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta2
{
    public class EntityDbContext: DbContext
    {
        public EntityDbContext() :base("DefaultConnection") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Desc> Descs { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
    }
}