namespace doonamis_technical_test.Models
{
    public class RoverModel
    {
        #region constructors

        public RoverModel()
        {
            Name = "FirstRover";
            Coordinates = new Coordinates();
            Orientation = OrientationEnum.North;
        }

        public RoverModel(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Name = "Rover";
            }

            Name = name;
            Coordinates = new Coordinates();
            Orientation = OrientationEnum.North;
        }

        public RoverModel(string name, Coordinates coordinates)
        {
            if (string.IsNullOrEmpty(name))
            {
                Name = "Rover";
            }
            Name = name;
            Coordinates = coordinates;
            Orientation = OrientationEnum.North;
        }

        public RoverModel(string name, Coordinates coordinates, OrientationEnum orientation)
        {
            if (string.IsNullOrEmpty(name))
            {
                Name = "Rover";
            }
            Name = name;
            Coordinates = coordinates;
            Orientation = orientation;
        }
        #endregion


        #region variables

        public string Name { get; set; }
        public Coordinates Coordinates { get; set; }
        public OrientationEnum Orientation { get; set; }
        public bool IsOutOfBounds { get; set; } = false;
        #endregion


        #region methods

        public OrientationEnum GetOrientation() { return Orientation; }
        public RoverModel ChangeOrientation(OrientationEnum orientationEnum)
        {
            Orientation = orientationEnum;
            return this;
        }

        public RoverModel Turn(char direction)
        {
            switch (Orientation)
            {
                case OrientationEnum.North:
                    Orientation = direction == 'L' ? OrientationEnum.West : OrientationEnum.East;
                    break;
                case OrientationEnum.South:
                    Orientation = direction == 'L' ? OrientationEnum.East : OrientationEnum.West;
                    break;
                case OrientationEnum.East:
                    Orientation = direction == 'L' ? OrientationEnum.North : OrientationEnum.South;
                    break;
                case OrientationEnum.West:
                    Orientation = direction == 'L' ? OrientationEnum.South : OrientationEnum.North;
                    break;
                default:
                    break;
            }
            return this;
        }

        public RoverModel MoveForward()
        {
            if (!IsOutOfBounds)
            {
                _ = Orientation switch
                {
                    OrientationEnum.North => Coordinates.X++,
                    OrientationEnum.South => Coordinates.X--,
                    OrientationEnum.East => Coordinates.Y++,
                    OrientationEnum.West => Coordinates.Y--,
                    _ => throw new NotImplementedException()
                };

                if (Coordinates.X == Globals.Mars.Max2DCoordinates.X || Coordinates.Y == Globals.Mars.Max2DCoordinates.Y)
                {
                    IsOutOfBounds = true;
                }

            }
            return this;
        }

        public RoverMovements HandleMovement(List<char> movements)
        {
            RoverMovements roverMovements = new();

            foreach (char mov in movements)
            {
                if (IsOutOfBounds)
                {
                    roverMovements.BlockedMovements.Add(mov);
                }
                else
                {
                    switch (mov)
                    {
                        case 'L':
                        case 'R':
                            Turn(mov);
                            roverMovements.MovementsDone.Add(mov);
                            break;
                        case 'F':
                            MoveForward();
                            roverMovements.MovementsDone.Add(mov);
                            break;
                        default:
                            roverMovements.BlockedMovements.Add(mov);
                            break;
                    }
                }
            }
            return roverMovements;
        }

        public Coordinates GetCoordinates()
        {
            return Coordinates;
        }
        public Coordinates ResetCoordinates()
        {
            Coordinates = new Coordinates();
            IsOutOfBounds = false;
            return Coordinates;
        }
        #endregion
    }
}

