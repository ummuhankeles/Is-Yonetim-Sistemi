using IsYonetimSistemi.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsYonetimSistemi.Entity.Dto
{
    public class DtoDepartment : DtoBase
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
