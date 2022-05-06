using IsYonetimSistemi.Dal.Abstract;
using IsYonetimSistemi.Entity.Dto;
using IsYonetimSistemi.Entity.Models;
using IsYonetimSistemi.Interface;
using System;

namespace IsYonetimSistemi.Bll
{
    public class TaskManager : GenericManager<Task, DtoTask>, ITaskService
    {
        public readonly ITaskRepository taskRepository;

        public TaskManager(IServiceProvider service) : base(service)
        {
        }
    }
}
