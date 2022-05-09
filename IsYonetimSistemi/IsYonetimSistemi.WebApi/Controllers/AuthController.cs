using IsYonetimSistemi.Entity.Base;
using IsYonetimSistemi.Entity.Dto;
using IsYonetimSistemi.Entity.IBase;
using IsYonetimSistemi.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace IsYonetimSistemi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IPersonelService personelService;
        public AuthController(IPersonelService personelService)
        {
            this.personelService = personelService;
        }

        [HttpPost("Login")]
        // [AllowAnonymous] // metodu token dan hariç tut
        public IResponse<DtoPersonelToken> Login(DtoLogin login)
        {
            try
            {
                return personelService.Login(login);
            }
            catch (Exception ex)
            {
                return new Response<DtoPersonelToken>
                {
                    Message = "Error:" + ex.Message,
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }
    }
}
