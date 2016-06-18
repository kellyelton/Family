using Family.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Family.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Relationship> Relationships { get; set; }
        public DbSet<RelationshipRequest> RelationshipRequests { get; set; }
        public DbSet<RelationshipType> RelationshipTypes { get; set; }
    }
}
