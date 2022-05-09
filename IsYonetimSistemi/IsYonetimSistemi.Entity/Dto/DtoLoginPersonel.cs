using IsYonetimSistemi.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsYonetimSistemi.Entity.Dto
{
    public class DtoLoginPersonel : DtoBase
    {
        public int PersonelId { get; set; }
        public string PersonelName { get; set; }
        public string PersonelSurname { get; set; }
        public string PersonelEmail { get; set; }
        public string PersonelPhone { get; set; }
        public int DepartmentId { get; set; }
        public int RoleId { get; set; }
    }
}
