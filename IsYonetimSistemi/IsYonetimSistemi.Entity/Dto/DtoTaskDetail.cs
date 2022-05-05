using IsYonetimSistemi.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsYonetimSistemi.Entity.Dto
{
    public class DtoTaskDetail : DtoBase
    {
        public int TaskDetailId { get; set; }
        public string TaskDetailDescription { get; set; }
        public DateTime Date { get; set; }
        public int TaskId { get; set; }
    }
}
