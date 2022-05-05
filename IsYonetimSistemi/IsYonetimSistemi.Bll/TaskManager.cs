using IsYonetimSistemi.Entity.Dto;
using IsYonetimSistemi.Entity.Models;
using IsYonetimSistemi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsYonetimSistemi.Bll
{
    public class TaskManager : GenericManager<Task, DtoTask>, ITaskService
    {
    }
}
