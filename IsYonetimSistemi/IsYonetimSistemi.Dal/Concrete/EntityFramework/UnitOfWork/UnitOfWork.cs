using IsYonetimSistemi.Dal.Abstract;
using IsYonetimSistemi.Dal.Concrete.EntityFramework.Repository;
using IsYonetimSistemi.Entity.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsYonetimSistemi.Dal.Concrete.EntityFramework.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Variables
        DbContext context;
        IDbContextTransaction transection;
        bool dispose;
        #endregion

        public UnitOfWork(DbContext context)
        {
            this.context = context;
        }

        public bool BeginTransection()
        {
            try
            {
                transection = context.Database.BeginTransaction();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // garbage collector çalıştırır
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!dispose)
            {
                if(disposing)
                {
                    context.Dispose();
                }
            }

            dispose = true;
        }

        public IGenericRepository<T> GetRepository<T>() where T : EntityBase
        {
            return new GenericRepository<T>(context);
        }

        public bool RollBackTransection()
        {
            try
            {
                transection.Rollback();
                transection = null;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int SaveChanges()
        {
            var _transection = transection != null ? transection : context.Database.BeginTransaction();
            using (_transection)
            {
                try
                {
                    if(context == null)
                    {
                        throw new ArgumentException("Context is null");
                    }

                    int result = context.SaveChanges();
                    _transection.Commit(); // transection onaylandığı yer
                    return result;
                }
                catch (Exception ex)
                {
                    transection.Rollback();
                    throw new Exception("Error on save changes", ex);
                }
            }
        }
    }
}
