using IsYonetimSistemi.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsYonetimSistemi.Entity.Dto
{
    public class DtoTask : DtoBase
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
