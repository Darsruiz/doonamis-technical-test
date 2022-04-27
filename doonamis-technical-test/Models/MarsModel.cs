namespace doonamis_technical_test.Models
{
    public class MarsModel
    {
        public MarsModel(Coordinates coordinates2D)
        {
            Max2DCoordinates = coordinates2D;
            Rovers = new HashSet<RoverModel>();
        }

        public bool Is3D { get; set; }
        public Coordinates BaseCoordinates { get; set; } = new Coordinates(0, 0, 0);
        public Coordinates Max2DCoordinates { get; set; }
        public Coordinates? Max3DCoordinates { get; set; }
        public HashSet<RoverModel> Rovers { get; set; }
    }
}

