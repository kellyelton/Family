using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family.DataModels
{
    public interface IAuditable
    {
        DateTime CreatedDate { get; set; }
        User CreatedBy { get; set; }
        DateTime ModifiedDate { get; set; }
        User ModifiedBy { get; set; }
    }
}