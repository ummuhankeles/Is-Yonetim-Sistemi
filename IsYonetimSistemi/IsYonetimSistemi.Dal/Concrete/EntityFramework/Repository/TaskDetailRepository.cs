using IsYonetimSistemi.Dal.Abstract;
using IsYonetimSistemi.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace IsYonetimSistemi.Dal.Concrete.EntityFramework.Repository
{
    public class TaskDetailRepository : GenericRepository<TaskDetail>, ITaskDetailRepository
    {
        public TaskDetailRepository(DbContext context) : base(context)
        {
        }
    }
}
