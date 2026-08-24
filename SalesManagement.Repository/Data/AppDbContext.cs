using Microsoft.EntityFrameworkCore;
using SalesManagement.Aggregators.PaymentMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Repository.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<PaymentMethodAggregatorsRoot> PaymentMethods { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PaymentMethodAggregatorsRoot>(entity =>
            {
                entity.HasKey(x => x.PaymentMethodId);

                entity.Property(x => x.PaymentMethodName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(x => x.Description)
                    .HasMaxLength(500);

                entity.Property(x => x.CreateDate)
                    .IsRequired();
            });
        }
    }
}
