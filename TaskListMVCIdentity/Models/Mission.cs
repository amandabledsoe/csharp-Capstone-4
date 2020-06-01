using System;
using System.Collections.Generic;

namespace TaskListMVCIdentity.Models
{
    public partial class Mission
    {
        public int Id { get; set; }
        public DateTime? DueDate { get; set; }
        public string MissionDescription { get; set; }
        public bool Completed { get; set; }
        public virtual AspNetUsers User { get; set; }
        public string UserId { get; internal set; }
    }
}
