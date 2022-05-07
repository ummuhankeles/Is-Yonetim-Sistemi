using IsYonetimSistemi.Dal.Abstract;
using IsYonetimSistemi.Entity.Dto;
using IsYonetimSistemi.Entity.Models;
using IsYonetimSistemi.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace IsYonetimSistemi.Bll
{
    public class PersonelManager : GenericManager<Personel, DtoPersonel>, IPersonelService 
    {
        public readonly IPersonelRepository personelRepository;

        public PersonelManager(IServiceProvider service) : base(service)
        {
            personelRepository = service.GetService<IPersonelRepository>();
        }
    }
}
