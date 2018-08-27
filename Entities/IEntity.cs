using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public interface IEntity
    {
        Guid Id { get; set; }
        DateTime DateCreated { get; set; }
        DateTime DateOfUpdate { get; set; }
        bool Cancelled { get; set; }
    }
}
