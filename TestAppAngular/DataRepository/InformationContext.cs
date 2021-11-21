using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAppAngular.Models
{
    public class Informationcontext: DbContext
    {
        public Informationcontext(DbContextOptions<Informationcontext> options):
            base(options) {}
        public DbSet<Information> Informations { get; set; }

    }
}
