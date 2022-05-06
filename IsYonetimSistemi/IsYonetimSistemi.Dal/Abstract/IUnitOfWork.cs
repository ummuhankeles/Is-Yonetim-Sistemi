using IsYonetimSistemi.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsYonetimSistemi.Dal.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> GetRepository<T>() where T : EntityBase;

        bool BeginTransection(); // transection başlatma
        bool RollBackTransection(); // hata durumunda geri alır
        int SaveChanges(); // transection onaylama
    }
}
