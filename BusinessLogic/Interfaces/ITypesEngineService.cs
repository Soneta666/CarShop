using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ITypesEngineService
    {
        Task<IEnumerable<TypeEngineDto>> GetAll();
        Task<TypeEngineDto?> GetById(int id);
        Task Create(TypeEngineDto typeEngineDto);
        Task Edit(TypeEngineDto typeEngineDto);
        Task Delete(int id);
    }
}
