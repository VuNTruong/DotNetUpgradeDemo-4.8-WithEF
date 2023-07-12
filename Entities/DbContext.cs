using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EFContext: DbContext
    {
        public EFContext() : base ("DotNetDatabase") { }

        public DbSet<User> Users { get; set; }
    }
}
