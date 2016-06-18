using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family.DataModels
{
    public class Person : IIdable, IAuditable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfDeath { get; set; }

        public Person Mother { get; set; }
        public Person Father { get; set; }

        public User Account { get; set; }

        public IList<Relationship> Relationships { get; set; }
        public DateTime CreatedDate { get; set; }
        public User CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public User ModifiedBy { get; set; }
    }
}
