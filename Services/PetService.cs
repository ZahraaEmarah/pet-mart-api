using pet_mart_api.Data;
using pet_mart_api.DTOs;
using pet_mart_api.Models;
using pet_mart_api.Services.Interfaces;

namespace pet_mart_api.Services
{
    public class PetService : IPetService
    {
        private readonly IRepository<Pet> _petRepository;
        //private readonly IMapper _mapper;

        public PetService(IRepository<Pet> petRepository)
        {
            _petRepository = petRepository;
            //_mapper = mapper;
        }

        public IEnumerable<Pet> GetAllPets()
        {
            var pets = _petRepository.GetAll();
            return pets;
        }

        public Pet AddPet(Pet petDto)

        {
            //var pet = _mapper.Map<Pet>(petDto);
            _petRepository.Add(petDto);
            return petDto;
        }
    }
}
