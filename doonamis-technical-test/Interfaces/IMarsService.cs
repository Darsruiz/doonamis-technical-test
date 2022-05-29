using doonamis_technical_test.Models;

namespace doonamis_technical_test.Interfaces
{
    public interface IMarsService
    {
        public HashSet<Coordinates> GetRoversPosition();

        public RoverModel? GetRoverByName(string name);

        public Coordinates GetBoundaries();
        public Coordinates Get3DBoundaries();

        public MarsModel GetMars();

        public MarsModel SetMarsBoundaries(Coordinates coordinates);
        public MarsModel SetMars3DBoundaries(Coordinates coordinates3D);
        public MarsModel ResetMars();

    }
}

