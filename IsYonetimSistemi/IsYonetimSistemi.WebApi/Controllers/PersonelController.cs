using IsYonetimSistemi.Entity.Dto;
using IsYonetimSistemi.Entity.Models;
using IsYonetimSistemi.Interface;
using IsYonetimSistemi.WebApi.Base;
using Microsoft.AspNetCore.Mvc;

namespace IsYonetimSistemi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelController : ApiBaseController<IPersonelService, Personel, DtoPersonel>
    {
        private readonly IPersonelService personelService;
        public PersonelController(IPersonelService personelService) : base(personelService)
        {
            this.personelService = personelService;
        }

        
    }
}
