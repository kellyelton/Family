using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family.DataModels
{
    public class RelationshipType : IIdable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public User CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public User ModifiedBy { get; set; }
    }
}