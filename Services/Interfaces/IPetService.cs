using pet_mart_api.DTOs;
using pet_mart_api.Models;

namespace pet_mart_api.Services.Interfaces
{
    public interface IPetService
    {
        //public PetDto AddPet(PetDto petDto);
        //public IEnumerable<PetDto> GetAllPets();
        public IEnumerable<Pet> GetAllPets();
    }
}
