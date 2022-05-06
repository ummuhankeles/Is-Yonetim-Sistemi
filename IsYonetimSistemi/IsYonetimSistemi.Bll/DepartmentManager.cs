using IsYonetimSistemi.Dal.Abstract;
using IsYonetimSistemi.Entity.Dto;
using IsYonetimSistemi.Entity.Models;
using IsYonetimSistemi.Interface;
using System;

namespace IsYonetimSistemi.Bll
{
    public class DepartmentManager : GenericManager<Department, DtoDepartment>, IDepartmentService
    {
        public readonly IDepartmentRepository departmentRepository;

        public DepartmentManager(IServiceProvider service) : base(service)
        {
        }
    }
}