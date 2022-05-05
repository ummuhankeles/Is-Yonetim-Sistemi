using IsYonetimSistemi.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace IsYonetimSistemi.Entity.Models
{
    public partial class Role : EntityBase
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
