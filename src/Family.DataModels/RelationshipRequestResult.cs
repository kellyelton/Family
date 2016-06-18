using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family.DataModels
{
    public enum RelationshipRequestResult
    {
        /// <summary>
        /// A <see cref="User"/> explicitly denied the request
        /// </summary>
        Denied,
        /// <summary>
        /// The <see cref="Person"/> requested doesn't have an associated <see cref="User"/>, so the relationship is assumed to be valid.
        /// </summary>
        Assumed,
        /// <summary>
        /// The <see cref="User"/> explicitly accepted the relationship
        /// </summary>
        Confirmed
    }
}