using IsYonetimSistemi.Entity.IBase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsYonetimSistemi.Interface
{
    public interface IGenericService<T, TDto> where T : IEntityBase where TDto : IDtoBase
    {
        // listeleme
        IResponse<List<TDto>> GetAll();

        // getirme
        IResponse<TDto> Find(int id);

        // kaydetme
        IResponse<TDto> Add(TDto item, bool saveChanges = true);

        // async kaydetme
        Task<IResponse<TDto>> AddAsync(TDto item, bool saveChanges = true);

        // güncelleme
        IResponse<TDto> Update(TDto item, bool saveChanges = true);

        // async güncelleme
        Task<IResponse<TDto>> UpdateAsync(TDto item, bool saveChanges = true);

        // silme
        IResponse<bool> DeleteById(int id, bool saveChanges = true);

        // async silme
        Task<IResponse<bool>> DeleteByIdAsync(int id, bool saveChanges = true);

        void Save();
    }
}
