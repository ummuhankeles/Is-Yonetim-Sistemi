using AutoMapper;
using IsYonetimSistemi.Entity.Dto;
using IsYonetimSistemi.Entity.Models;

namespace IsYonetimSistemi.Entity.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Personel, DtoPersonel>().ReverseMap();
            CreateMap<Department, DtoDepartment>().ReverseMap();
            CreateMap<Task, DtoTask>().ReverseMap();
            CreateMap<TaskDetail, DtoTaskDetail>().ReverseMap();
            CreateMap<Personel, DtoLoginPersonel>();
            CreateMap<DtoLogin, Personel>();
        }
    }
}
