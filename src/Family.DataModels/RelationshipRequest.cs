using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family.DataModels
{
    public class RelationshipRequest : IIdable, IAuditable
    {
        public int Id { get; set; }

        public User Requester { get; set; }
        public Person With { get; set; }
        public RelationshipType RelationshipType { get; set; }

        public RelationshipRequestResult Result { get; set; }
        public bool Completed { get; set; }
        public DateTime CompletedDate { get; set; }
        public User CompletedBy { get; set; }

        public DateTime CreatedDate { get; set; }
        public User CreatedBy { get; set; }

        [Obsolete]
        public DateTime ModifiedDate { get; set; }
        [Obsolete]
        public User ModifiedBy { get; set; }
    }
}