using IsYonetimSistemi.Entity.Base;
using System.ComponentModel.DataAnnotations;

namespace IsYonetimSistemi.Entity.Dto
{
    public class DtoLogin : DtoBase
    {
        [Required]
        public string PersonelEmail { get; set; }

        [Required]
        public string PersonelPassword { get; set; }
    }
}
