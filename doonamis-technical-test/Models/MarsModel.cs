namespace doonamis_technical_test.Models
{
    public class MarsModel
    {
        public MarsModel(Coordinates coordinates)
        {
            Is3D = false;
            Max2DCoordinates = coordinates;
        }

        public MarsModel(Coordinates coordinates2D, Coordinates coordinates3D)
        {
            Max2DCoordinates = coordinates2D;
            Max3DCoordinates = coordinates3D;
            Is3D = true;
        }

        public bool Is3D { get; set; }
        public Coordinates BaseCoordinates { get; set; } = new Coordinates(0, 0, 0);
        public Coordinates Max2DCoordinates { get; set; }
        public Coordinates? Max3DCoordinates { get; set; }
    }
}

