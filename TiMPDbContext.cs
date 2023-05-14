using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TiMP_CourseWork 
{
    internal class TiMPDbContext : DbContext
    {
        public DbSet<InitValues> initvalues { get; set; }
        public DbSet<OutValues> outvalues { get; set; }

        internal TimpPGSQLSender TimpPGSQLSender
        {
            get => default;
            set
            {
            }
        }

        public TiMPDbContext(DbContextOptions<TiMPDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InitValues>()
            .HasKey(e => e.id_Eq);
            modelBuilder.Entity<OutValues>()
            .HasKey( e => e.id_result);
        }
        


    }
}
