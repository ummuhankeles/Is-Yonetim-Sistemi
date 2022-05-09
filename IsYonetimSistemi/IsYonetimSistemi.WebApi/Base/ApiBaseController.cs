using IsYonetimSistemi.Entity.Base;
using IsYonetimSistemi.Entity.IBase;
using IsYonetimSistemi.Interface;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace IsYonetimSistemi.WebApi.Base
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)] // apibase den kalıtım alan her yerin authorize yetkisi sorgulansın
    public class ApiBaseController<TService, T, TDto> : ControllerBase where TService : IGenericService<T, TDto> where T : EntityBase where TDto : DtoBase
    {
        private readonly TService service;

        public ApiBaseController(TService service)
        {
            this.service = service; 
        }

        [HttpGet("Find")]
        public IResponse<TDto> Find(int id)
        {
            try
            {
                return service.Find(id);
            }
            catch (Exception ex)
            {
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        [HttpGet("GetAll")]
        public IResponse<List<TDto>> GetAll()
        {
            try
            {
                return service.GetAll();
            }
            catch (Exception ex)
            {
                return new Response<List<TDto>>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        [HttpPost("Add")]
        public IResponse<TDto> Add(TDto item)
        {
            try
            {
                return service.Add(item);
            }
            catch (Exception ex)
            {
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        [HttpPut("Update")]
        public IResponse<TDto> Update(TDto item)
        {
            try
            {
                return service.Update(item);
            }
            catch (Exception ex)
            {
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        [HttpDelete("Delete")]
        public IResponse<bool> Delete(int id)
        {
            try
            {
                return service.DeleteById(id);
            }
            catch (Exception ex)
            {
                return new Response<bool>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = false
                };
            }
        }
    }
}
