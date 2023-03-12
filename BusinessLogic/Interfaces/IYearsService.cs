using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IYearsService
    {
        Task<IEnumerable<YearDto>> GetAll();
        Task<YearDto?> GetById(int id);
        Task Create(YearDto years);
        Task Edit(YearDto years);
        Task Delete(int id);
    }
}
