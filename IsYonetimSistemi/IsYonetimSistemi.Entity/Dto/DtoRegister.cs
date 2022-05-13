using IsYonetimSistemi.Entity.Base;
using System.ComponentModel.DataAnnotations;

namespace IsYonetimSistemi.Entity.Dto
{
    public class DtoRegister : DtoBase
    {
        [Required]
        public string PersonelName { get; set; }

        [Required]
        public string PersonelSurname { get; set; }

        [Required]
        public string PersonelEmail { get; set; }

        [Required]
        public string PersonelPassword { get; set; }

        public string PersonelPhone { get; set; }

        [Required]
        public int RoleId = 3;

        [Required]
        public int DepartmentId { get; set; }
    }
}
