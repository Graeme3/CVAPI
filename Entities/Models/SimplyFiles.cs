using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class SimplyFiles : IEntity
    {
        public Guid Id { get; set; }
        public Guid SimpleFileGuid { get; set; }
        public string FileName { get; set; }
        public string MIME { get; set; }
        public int MyProperty { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateOfUpdate { get; set; }
        public bool Cancelled { get; set; }
    }
}
