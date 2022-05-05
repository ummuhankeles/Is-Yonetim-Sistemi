using IsYonetimSistemi.Dal.Abstract;
using IsYonetimSistemi.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace IsYonetimSistemi.Dal.Concrete.EntityFramework.Repository
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(DbContext context) : base(context)
        {
        }
    }
}
