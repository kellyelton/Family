using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Family.DataModels
{
    public class User : IIdable, IAuditable
    {
        public int Id { get; set; }
        public Person Self { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public User CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public User ModifiedBy { get; set; }
    }
}