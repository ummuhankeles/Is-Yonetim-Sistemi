using IsYonetimSistemi.Dal.Abstract;
using IsYonetimSistemi.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IsYonetimSistemi.Dal.Concrete.EntityFramework.Repository
{
    public class PersonelRepository : GenericRepository<Personel>, IPersonelRepository
    {
        public PersonelRepository(DbContext context) : base(context)
        {
        }

        public Personel Login(Personel login)
        {
            var personel = dbSet.Where(x => x.PersonelEmail == login.PersonelEmail && x.PersonelPassword == login.PersonelPassword).SingleOrDefault();

            return personel;
        }
    }
}
