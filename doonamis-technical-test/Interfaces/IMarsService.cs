using doonamis_technical_test.Models;

namespace doonamis_technical_test.Interfaces
{
    public interface IMarsService
    {
        public Task<HashSet<RoverModel>> GetRoverPosition();

        public Task<Coordinates> GetRoverPositionByName(string name);

        public Task<bool> CheckBoundaries();

        public Task<MarsModel> GetMars();

        public Task<MarsModel> SetMarsBoundaries();

    }
}

