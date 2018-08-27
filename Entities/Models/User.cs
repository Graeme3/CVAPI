using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class User : IEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string IdNumber { get; set; }       
        public Guid SimpleFileImage { get; set; }
        public string FileName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateOfUpdate { get; set; }
        public bool Cancelled { get; set; }
    }
}
