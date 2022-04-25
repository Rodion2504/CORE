using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using АПТ_Core.Models;

namespace АПТ_Core.Data
{
    public class TehContext:DbContext
    {
        
        public TehContext(DbContextOptions<TehContext> options)
            :base(options)
        {
           
        }
        public DbSet<Stud> Stud { get; set; }
        public DbSet<Teach> Teach { get; set; }
    }
}
