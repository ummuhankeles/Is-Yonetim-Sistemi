using IsYonetimSistemi.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace IsYonetimSistemi.Entity.Models
{
    public partial class TaskDetail : EntityBase
    {
        public int TaskDetailId { get; set; }
        public string TaskDetailDescription { get; set; }
        public DateTime Date { get; set; }
        public int TaskId { get; set; }
    }
}
