using IsYonetimSistemi.Entity.Dto;
using IsYonetimSistemi.Entity.Models;
using IsYonetimSistemi.Interface;
using IsYonetimSistemi.WebApi.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsYonetimSistemi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ApiBaseController<IDepartmentService, Department, DtoDepartment>
    {
        private readonly IDepartmentService departmentService;

        public DepartmentController(IDepartmentService service) : base(service)
        {
            this.departmentService = departmentService;
        }


    }
}
