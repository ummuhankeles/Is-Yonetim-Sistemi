using IsYonetimSistemi.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace IsYonetimSistemi.Entity.Models
{
    public partial class Task : EntityBase
    {
        public int TaskId { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public string TaskPriority { get; set; }
        public DateTime Date { get; set; }
        public int PersonelId { get; set; }
        public int DepartmentId { get; set; }
    }
}
