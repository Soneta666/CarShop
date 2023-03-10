using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class CarsService : ICarsService
    {

        private readonly IRepository<Car> moviesRepo;
        private readonly IMapper mapper;

        public CarsService(IRepository<Car> moviesRepo, IMapper mapper)
        {
            this.moviesRepo = moviesRepo;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<CarDto>> GetAll()
        {
            var result = await moviesRepo.GetListBySpec(new Cars.GetAll());

            return mapper.Map<IEnumerable<CarDto>>(result);
        }

        public async Task<IEnumerable<CarDto>> GetOrder(string order)
        {
            IEnumerable<Car> result;
            if(order == "orderbycountry" || order == "country" || order == "bycountry") 
                result = await moviesRepo.GetListBySpec(new Cars.OrderedByCountry());
            else if(order == "orderbymakename" || order == "bymakename" || order == "makename") 
                result = await moviesRepo.GetListBySpec(new Cars.OrderedByMakeName());
            else if(order == "orderbymaxspeed" || order == "bymaxspeed" || order == "maxspeed") 
                result = await moviesRepo.GetListBySpec(new Cars.OrderedByMaxSpeed());
            else if(order == "orderbyyear" || order == "byyear" || order == "year") 
                result = await moviesRepo.GetListBySpec(new Cars.OrderedByYear());
            else
                result = await moviesRepo.GetListBySpec(new Cars.OrderedByModelName());

            return mapper.Map<IEnumerable<CarDto>>(result);
        }

        public async Task<CarDto?> GetById(int id)
        {
            Car? item = await moviesRepo.GetItemBySpec(new Cars.ById(id));

            if (item == null) return null;

            return mapper.Map<CarDto>(item);
        }

        public async Task Edit(CarDto dto)
        {
            await moviesRepo.Update(mapper.Map<Car>(dto));
            await moviesRepo.Save();
        }

        public async Task Create(CarDto dto)
        {
            await moviesRepo.Insert(mapper.Map<Car>(dto));
            await moviesRepo.Save();
        }

        public async Task Delete(int id)
        {
            if (await moviesRepo.GetById(id) == null) return; 

            await moviesRepo.Delete(id);
            await moviesRepo.Save();
        }
    }
}
