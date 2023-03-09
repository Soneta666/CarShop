using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICarsService
    {
        Task<IEnumerable<CarDto>> GetAll();
        Task<CarDto?> GetById(int id);
        Task Create(CarDto car);
        Task Edit(CarDto car);
        Task Delete(int id);
    }
}
