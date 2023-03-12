using Ardalis.Specification;
using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.Helpers;
using Core.Interfaces;
using Core.Resources;
using Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class TypeEngineService : ITypesEngineService
    {
        private readonly IRepository<TypeEngine> typesRepo;
        private readonly IMapper mapper;

        public TypeEngineService(IRepository<TypeEngine> typesRepo, IMapper mapper)
        {
            this.typesRepo = typesRepo;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<TypeEngineDto>> GetAll()
        {
            var result = await typesRepo.GetAll();

            return (IEnumerable<TypeEngineDto>)mapper.Map<IEnumerable<TypeEngine>>(result);
        }

        public async Task<TypeEngineDto?> GetById(int id)
        {
            var item = await typesRepo.GetById(id);

            if (item == null)
                throw new HttpException(ErrorMessages.TypeEngineNotFound, HttpStatusCode.NotFound);

            return mapper.Map<TypeEngineDto>(item);
        }

        public async Task Edit(TypeEngineDto typeDto)
        {
            await typesRepo.Update(mapper.Map<TypeEngine>(typeDto));
            await typesRepo.Save();
        }

        public async Task Create(TypeEngineDto typeDto)
        {
            await typesRepo.Insert(mapper.Map<TypeEngine>(typeDto));
            await typesRepo.Save();
        }

        public async Task Delete(int id)
        {
            if (await typesRepo.GetById(id) == null)
                throw new HttpException(ErrorMessages.TypeEngineNotFound, HttpStatusCode.NotFound);

            await typesRepo.Delete(id);
            await typesRepo.Save();
        }
    }
}
