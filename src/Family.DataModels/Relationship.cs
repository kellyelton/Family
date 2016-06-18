using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family.DataModels
{
    public class Relationship : IIdable, IAuditable
    {
        public int Id { get; set; }
        public Person Person1 { get; set; }
        public Person Person2 { get; set; }

        public RelationshipType RelationshipType { get; set; }
        public DateTime CreatedDate { get; set; }
        public User CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public User ModifiedBy { get; set; }
    }
}