using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IModelService
    {
        Task<IEnumerable<MakeDto>> GetAll();
        Task<IEnumerable<MakeDto>> GetOrder();
        Task<MakeDto?> GetById(int id);
        Task Create(MakeDto make);
        Task Edit(MakeDto make);
        Task Delete(int id);
    }
}
