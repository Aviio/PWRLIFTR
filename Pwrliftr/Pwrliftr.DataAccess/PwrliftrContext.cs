using Pwrliftr.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pwrliftr.DataAccess
{
    public class PwrliftrContext : DbContext
    {
        public PwrliftrContext() : base("PwrliftrContext")
        {

        }

        public DbSet<Competitor> Competitors { get; set; }
    }
}
