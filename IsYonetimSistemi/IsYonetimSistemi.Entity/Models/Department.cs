using IsYonetimSistemi.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace IsYonetimSistemi.Entity.Models
{
    public partial class Department : EntityBase
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
