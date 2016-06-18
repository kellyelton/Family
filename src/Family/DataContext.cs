using Family.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Family
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Relationship> Relationships { get; set; }
        public DbSet<RelationshipRequest> RelationshipRequests { get; set; }
        public DbSet<RelationshipType> RelationshipTypes { get; set; }

        public DataContext() {
            
        }

        public DataContext( DbContextOptions<DataContext> options ) 
            : base(options) {
            
        }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder ) {
            base.OnConfiguring(optionsBuilder);
            
        }

        protected override void OnModelCreating( ModelBuilder modelBuilder ) {
            base.OnModelCreating(modelBuilder);
            {
                var et = modelBuilder.Entity<User>();
                et.HasKey(x => x.Id);
                et.HasOne(x => x.CreatedBy);
                et.HasOne(x => x.ModifiedBy);

                et.HasOne<Person>(y => y.Self);
            }
            {
                var et = modelBuilder.Entity<Person>();
                et.HasKey(x => x.Id);
                et.HasOne(x => x.CreatedBy);
                et.HasOne(x => x.ModifiedBy);

                et.HasOne(x => x.Account);
                et.HasOne(x => x.Father);
                et.HasOne(x => x.Mother);
                et.HasMany(x => x.Relationships);
            }
            {
                var et = modelBuilder.Entity<Relationship>();
                et.HasKey(x => x.Id);
                et.HasOne(x => x.CreatedBy);
                et.HasOne(x => x.ModifiedBy);

                et.HasOne(x => x.Person1).WithMany(x=>x.Relationships);
                et.HasOne(x => x.Person2).WithMany(x => x.Relationships);
                et.HasOne(x => x.RelationshipType);
            }
            {
                var et = modelBuilder.Entity<RelationshipRequest>();
                et.HasKey(x => x.Id);
                et.HasOne(x => x.CreatedBy);
                et.HasOne(x => x.ModifiedBy);

                et.HasOne(x => x.RelationshipType);
                et.HasOne(x => x.Requester);
                et.HasOne(x => x.With);
            }
            {
                var et = modelBuilder.Entity<RelationshipType>();
                et.HasKey(x => x.Id);
                et.HasOne(x => x.CreatedBy);
                et.HasOne(x => x.ModifiedBy);
            }
        }
    }
}
