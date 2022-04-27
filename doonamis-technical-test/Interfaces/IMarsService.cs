using doonamis_technical_test.Models;

namespace doonamis_technical_test.Interfaces
{
    public interface IMarsService
    {
        public HashSet<Coordinates> GetRoversPosition();

        public RoverModel GetRoverByName(string name);

        public Coordinates GetBoundaries();
        public HashSet<Coordinates> Get3DBoundaries();

        public MarsModel GetMars();

        public MarsModel SetMarsBoundaries(double x, double y);
        public MarsModel SetMarsBoundaries(double x, double y, double z);
        public MarsModel SetMarsBoundaries(Coordinates coordinates);
        public MarsModel SetMarsBoundaries(Coordinates coordinates2D, Coordinates coordinates3D);

    }
}

