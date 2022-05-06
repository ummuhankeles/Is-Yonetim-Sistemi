using IsYonetimSistemi.Dal.Abstract;
using IsYonetimSistemi.Entity.Dto;
using IsYonetimSistemi.Entity.Models;
using IsYonetimSistemi.Interface;
using System;

namespace IsYonetimSistemi.Bll
{
    public class TaskDetailManager : GenericManager<TaskDetail, DtoTaskDetail>, ITaskDetailService
    {
        public readonly ITaskDetailRepository taskDetailRepository;

        public TaskDetailManager(IServiceProvider service) : base(service)
        {
        }
    }
}
