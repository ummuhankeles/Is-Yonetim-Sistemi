using IsYonetimSistemi.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace IsYonetimSistemi.Entity.Models
{
    public partial class Personel : EntityBase
    {
        public int PersonelId { get; set; }
        public string PersonelName { get; set; }
        public string PersonelSurname { get; set; }
        public string PersonelEmail { get; set; }
        public string PersonelPhone { get; set; }
        public string PersonelPassword { get; set; }
        public int DepartmentId { get; set; }
        public int RoleId { get; set; }
    }
}
