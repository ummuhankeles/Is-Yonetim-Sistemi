using IsYonetimSistemi.Entity.Dto;
using IsYonetimSistemi.Entity.IBase;
using IsYonetimSistemi.Entity.Models;

namespace IsYonetimSistemi.Interface
{
    public interface IPersonelService : IGenericService<Personel, DtoPersonel>
    {
        IResponse<DtoPersonelToken> Login(DtoLogin login);
    }
}
