using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Khoa> Khoa { get; set; }
        public virtual DbSet<ThongTinSV> ThongTinSV { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.ThongTinSV)
                .WithRequired(e => e.Khoa)
                .WillCascadeOnDelete(false);
        }
    }
}
