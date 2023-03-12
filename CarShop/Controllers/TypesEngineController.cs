using Core.DTOs;
using Core.Interfaces;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypesEngineController : ControllerBase
    {
        private readonly ITypesEngineService typeEngine;

        public TypesEngineController(ITypesEngineService typeEngine)
        {
            this.typeEngine = typeEngine;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await typeEngine.GetAll());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var item = await typeEngine.GetById(id);
            if (item == null) return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TypeEngineDto typeEngineDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            await typeEngine.Create(typeEngineDto);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] TypeEngineDto typeEngineDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            await typeEngine.Edit(typeEngineDto);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await typeEngine.Delete(id);

            return Ok();
        }
    }
}
