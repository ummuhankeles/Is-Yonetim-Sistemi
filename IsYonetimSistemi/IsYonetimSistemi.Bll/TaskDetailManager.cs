using IsYonetimSistemi.Entity.Dto;
using IsYonetimSistemi.Entity.Models;
using IsYonetimSistemi.Interface;

namespace IsYonetimSistemi.Bll
{
    public class TaskDetailManager : GenericManager<TaskDetail, DtoTaskDetail>, ITaskDetailService
    {
    }
}
