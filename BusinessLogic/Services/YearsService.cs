using AutoMapper;
using Core.DTOs;
using Core.Helpers;
using Core.Interfaces;
using Core.Resources;
using Itenso.TimePeriod;
using System.Net;

namespace Core.Services
{
    public class YearsService : IYearsService
    {
        private readonly IRepository<Year> yearsRepo;
        private readonly IMapper mapper;

        public YearsService(IRepository<Year> yearsRepo, IMapper mapper)
        {
            this.yearsRepo = yearsRepo;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<YearDto>> GetAll()
        {
            var result = await yearsRepo.GetAll();

            return (IEnumerable<YearDto>)mapper.Map<IEnumerable<Year>>(result);
        }

        public async Task<YearDto?> GetById(int id)
        {
            //TypeEngine? item = await typesRepo.GetById(id);

            var item = await yearsRepo.GetById(id);

            if (item == null)
                throw new HttpException(ErrorMessages.YearNotFound, HttpStatusCode.NotFound);

            return mapper.Map<YearDto>(item);
        }

        public async Task Edit(YearDto yearDto)
        {
            await yearsRepo.Update(mapper.Map<Year>(yearDto));
            await yearsRepo.Save();
        }

        public async Task Create(YearDto yearDto)
        {
            await yearsRepo.Insert(mapper.Map<Year>(yearDto));
            await yearsRepo.Save();
        }

        public async Task Delete(int id)
        {
            if (await yearsRepo.GetById(id) == null)
                throw new HttpException(ErrorMessages.YearNotFound, HttpStatusCode.NotFound);

            await yearsRepo.Delete(id);
            await yearsRepo.Save();
        }
    }
}
