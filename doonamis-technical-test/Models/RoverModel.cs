namespace doonamis_technical_test.Models
{
    public class RoverModel
    {
        public RoverModel(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Name = "Rover";
            }

            Name = name;
            Coordinates = new Coordinates();
        }

        public RoverModel(string name, Coordinates coordinates)
        {
            Name = name;
            Coordinates = coordinates;
        }
        #region variables

        public string Name { get; set; }
        public Coordinates Coordinates { get; set; }
        public OrientationEnum Orientation { get; set; }
        #endregion


        #region methods

        public OrientationEnum GetOrientation() { return Orientation; }
        public RoverModel ChangeOrientation(OrientationEnum orientationEnum)
        {
            Orientation = orientationEnum;
            return this;
        }

        public RoverModel MoveForward()
        {
            _ = Orientation switch
            {
                OrientationEnum.North => Coordinates.Y++,
                OrientationEnum.South => Coordinates.Y--,
                OrientationEnum.East => Coordinates.X++,
                OrientationEnum.West => Coordinates.X--,
                OrientationEnum.Up => Coordinates.Z++,
                OrientationEnum.Down => Coordinates.Z--,
                _ => throw new NotImplementedException()
            };
            return this;
        }
        public Coordinates GetCoordinates()
        {
            return Coordinates;
        }
        public Coordinates ResetCoordinates()
        {
            Coordinates = new Coordinates();
            return Coordinates;
        }
        #endregion
    }
}

