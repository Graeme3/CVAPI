using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class GameScore : IEntity
    {
        public Guid Id { get; set; }
        public string GameName {get;set;}
        public bool WinLose { get; set; }
        public string ComputerScore { get; set; }
        public string PlayerScore { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateOfUpdate { get; set; }
        public bool Cancelled { get; set; }
    }
}
