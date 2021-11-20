using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAppAngular.Models
{
    public class InformationContext: DbContext
    {
        public InformationContext(DbContextOptions<InformationContext> options):
            base(options) {}
        public DbSet<Information> Information { get; set; }
        public string DbPath { get; private set; }

    }
}
