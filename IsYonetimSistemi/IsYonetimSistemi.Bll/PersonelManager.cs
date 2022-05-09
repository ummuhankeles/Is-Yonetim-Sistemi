using IsYonetimSistemi.Dal.Abstract;
using IsYonetimSistemi.Entity.Dto;
using IsYonetimSistemi.Entity.Models;
using IsYonetimSistemi.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;
using IsYonetimSistemi.Entity.IBase;
using IsYonetimSistemi.Entity.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace IsYonetimSistemi.Bll
{
    public class PersonelManager : GenericManager<Personel, DtoPersonel>, IPersonelService 
    {
        public readonly IPersonelRepository personelRepository;
        private IConfiguration configuration;

        public PersonelManager(IServiceProvider service, IConfiguration configuration) : base(service)
        {
            personelRepository = service.GetService<IPersonelRepository>();
            this.configuration = configuration;
        }

        public IResponse<DtoPersonelToken> Login(DtoLogin login)
        {
            var personel = personelRepository.Login(ObjectMapper.Mapper.Map<Personel>(login));

            if(personel != null)
            {
                var dtoPersonel = ObjectMapper.Mapper.Map<DtoLoginPersonel>(personel);

                var token = new TokenManager(configuration).CreateAccessToken(dtoPersonel);

                var personelToken = new DtoPersonelToken()
                {
                    DtoLoginPersonel = dtoPersonel,
                    AccessToken = token
                };

                return new Response<DtoPersonelToken>
                {
                    Message = "Token is success",
                    StatusCode = StatusCodes.Status200OK,
                    Data = personelToken
                };
            }
            else
            {
                return new Response<DtoPersonelToken>
                {
                    Message = "Wrong username or password!",
                    StatusCode = StatusCodes.Status406NotAcceptable,
                    Data = null
                };
            }
        }
    }
}
