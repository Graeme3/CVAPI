using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class College : IEntity
    {
        
        public Guid Id { get; set; }
        public string CollageName { get; set; }
        public string DiplomaName { get; set; }
        public string FileName { get; set; }
        public Dictionary<string,int> FirstYearCourse { get; set; }
        public Dictionary<string, int> SecondYearCourse { get; set; }
        public Dictionary<string, int> ThirdYearCourse { get; set; }
        public Guid SimpleFileGuid { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateOfUpdate { get; set; }
        public Guid UserID { get; set; }
        public bool Cancelled { get; set; }
    }
}
