using Core.DTOs;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly IModelsService modelsService;

        public ModelsController(IModelsService modelsService)
        {
            this.modelsService = modelsService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await modelsService.GetAll());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var item = await modelsService.GetById(id);
            if (item == null) return NotFound();

            return Ok(item);
        }

        [HttpGet("{orderBy:alpha}")]
        public async Task<IActionResult> GetOrder([FromRoute] string orderBy)
        {
            if (orderBy.Split(' ').Length > 1)
            {
                string[] orderByStr = orderBy.Split(' ');
                orderBy = "";
                for (int i = 0; i < orderByStr.Length; i++)
                {
                    orderBy += orderByStr[i];
                }
            }
            var item = await modelsService.Order(orderBy.ToLower());
            if (item == null) return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ModelDto model)
        {
            if (!ModelState.IsValid) return BadRequest();

            await modelsService.Create(model);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] ModelDto model)
        {
            if (!ModelState.IsValid) return BadRequest();

            await modelsService.Edit(model);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await modelsService.Delete(id);

            return Ok();
        }
    }
}
