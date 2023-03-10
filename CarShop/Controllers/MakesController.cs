using Core.DTOs;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        private readonly IMakesService makesService;

        public MakesController(IMakesService makesService)
        {
            this.makesService = makesService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await makesService.GetAll());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var item = await makesService.GetById(id);
            if (item == null) return NotFound();

            return Ok(item);
        }

        [HttpGet("{orderBy:alpha}")]
        public async Task<IActionResult> GetOrder()
        {
            var item = await makesService.GetOrder();
            if (item == null) return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MakeDto make)
        {
            if (!ModelState.IsValid) return BadRequest();

            await makesService.Create(make);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] MakeDto make)
        {
            if (!ModelState.IsValid) return BadRequest();

            await makesService.Edit(make);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await makesService.Delete(id);

            return Ok();
        }
    }
}
