using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class HighSchool : IEntity
    {
        public Guid Id { get; set; }
        public string HighSchoolName { get; set; }
        public DateTime Gradutation { get; set; }
        public Guid SimpleFileGuid { get; set; }
        public string FileName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateOfUpdate { get; set; }
        public Guid UserID { get; set; }
        public bool Cancelled { get; set; }
    }
}
