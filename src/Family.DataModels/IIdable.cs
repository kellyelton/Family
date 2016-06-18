using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family.DataModels
{
    public interface IIdable
    {
        int Id { get; set; }
    }
}