using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pet_mart_api.Models;
using pet_mart_api.Services.Interfaces;

namespace pet_mart_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetService _petService;

        public PetController(IPetService petService)
        {
            _petService = petService;
        }

        [HttpGet("GetPets")]
        public IActionResult GetPets()
        {
            return Ok(_petService.GetAllPets());
        }

        [HttpPost]
        public IActionResult AddPet(Pet pet)
        {
            return Ok();
        }
    }
}
