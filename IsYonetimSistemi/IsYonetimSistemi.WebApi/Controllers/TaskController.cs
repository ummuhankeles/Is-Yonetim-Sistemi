using IsYonetimSistemi.Entity.Dto;
using IsYonetimSistemi.Entity.Models;
using IsYonetimSistemi.Interface;
using IsYonetimSistemi.WebApi.Base;
using Microsoft.AspNetCore.Mvc;

namespace IsYonetimSistemi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ApiBaseController<ITaskService, Task, DtoTask>
    {
        private readonly ITaskService taskService;
        public TaskController(ITaskService service) : base(service)
        {
            this.taskService = taskService;
        }
    }
}
