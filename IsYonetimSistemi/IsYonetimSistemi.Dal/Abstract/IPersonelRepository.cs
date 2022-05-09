using IsYonetimSistemi.Entity.Models;

namespace IsYonetimSistemi.Dal.Abstract
{
    public interface IPersonelRepository
    {
        Personel Login(Personel login);
    }
}
