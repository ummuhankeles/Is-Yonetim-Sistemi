using IsYonetimSistemi.Entity.Base;
using IsYonetimSistemi.Entity.IBase;
using IsYonetimSistemi.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsYonetimSistemi.Bll
{
    public class GenericManager<T, TDto> : IGenericService<T, TDto> where T : EntityBase where TDto : DtoBase
    {
        public IResponse<TDto> Add(TDto item, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Task<IResponse<TDto>> AddAsync(TDto item, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public IResponse<bool> DeleteById(int id, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Task<IResponse<bool>> DeleteByIdAsync(int id, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public IResponse<TDto> Find(int id)
        {
            throw new NotImplementedException();
        }

        public IResponse<List<TDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResponse<TDto> Update(TDto item, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Task<IResponse<TDto>> UpdateAsync(TDto item, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
