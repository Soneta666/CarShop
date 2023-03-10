using Core.DTOs;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarsService carsService;

        public CarsController(ICarsService carsService)
        {
            this.carsService = carsService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await carsService.GetAll());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var item = await carsService.GetById(id);
            if (item == null) return NotFound();

            return Ok(item);
        }

        [HttpGet("{orderBy:alpha}")]
        public async Task<IActionResult> GetOrder([FromRoute] string orderBy)
        {   
            if(orderBy.Split(' ').Length > 1)
            {
                string[] orderByStr = orderBy.Split(' ');
                orderBy = "";
                for (int i = 0; i < orderByStr.Length; i++)
                {
                    orderBy += orderByStr[i];
                }
            }
            var item = await carsService.GetOrder(orderBy.ToLower());
            if (item == null) return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CarDto car)
        {
            if (!ModelState.IsValid) return BadRequest();

            await carsService.Create(car);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] CarDto car)
        {
            if (!ModelState.IsValid) return BadRequest();

            await carsService.Edit(car);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await carsService.Delete(id);

            return Ok();
        }
    }
}
