using IsYonetimSistemi.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsYonetimSistemi.Dal.Abstract
{
    public interface IGenericRepository<T> where T : IEntityBase
    {
        // listeleme
        List<T> GetAll();

        // getirme
        T Find(int id);

        // kaydetme
        T Add(T item);

        // async kaydetme
        Task<T> AddAsync(T item);

        // güncelleme
        T Update(T item);

        // silme
        bool Delete(int id);

        bool Delete(T item);
    }
}
