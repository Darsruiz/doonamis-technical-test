namespace doonamis_technical_test.Models
{
    public class MarsModel
    {
        #region constructors

        public MarsModel()
        {
            Max2DCoordinates = new Coordinates();
            Max3DCoordinates = new Coordinates();
            Rovers = new HashSet<RoverModel>()
            {
                new RoverModel()
            };
        }

        public MarsModel(Coordinates coordinates2D)
        {
            Max2DCoordinates = coordinates2D;
            Max3DCoordinates = new Coordinates();
            Rovers = new HashSet<RoverModel>()
            {
                new RoverModel()
            };
        }

        public MarsModel(Coordinates coordinates2D, Coordinates coordinates3D)
        {
            Max2DCoordinates = coordinates2D;
            Max3DCoordinates = coordinates3D;
            Rovers = new HashSet<RoverModel>()
            {
                new RoverModel()
            };
        }
        #endregion

        public bool Is3D { get; set; } = false;
        public Coordinates BaseCoordinates { get; set; } = new Coordinates();
        public Coordinates Max2DCoordinates { get; set; }
        public Coordinates Max3DCoordinates { get; set; }
        public HashSet<RoverModel> Rovers { get; set; }
    }
}

