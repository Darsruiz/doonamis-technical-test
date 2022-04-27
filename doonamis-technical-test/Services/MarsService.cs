using System;
using System.Collections.Generic;
using System.Diagnostics;
using doonamis_technical_test.Interfaces;
using doonamis_technical_test.Models;

namespace doonamis_technical_test.Services
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class MarsService : IMarsService
    {
        private MarsModel marsModel;

        public MarsService(Mars _mars)
        {
            marsModel = _mars;
        }

        public HashSet<Coordinates> GetRoversPosition()
        {
            HashSet <Coordinates> coordinatesList = marsModel.Rovers
                .Select(x => x.Coordinates)
                .ToHashSet();
            return coordinatesList;
        }

        public Coordinates GetBoundaries()
        {
            return marsModel.Max2DCoordinates;
        }
        public HashSet<Coordinates> Get3DBoundaries()
        {
            return new HashSet<Coordinates>
            {
                marsModel.Max2DCoordinates,
                marsModel.Max3DCoordinates ?? new Coordinates()
            };
        }

        public MarsModel GetMars()
        {
            return marsModel;
        }

        public HashSet<RoverModel> GetRover()
        {
            return marsModel.Rovers;
        }

        public RoverModel GetRoverByName(string name)
        {
            RoverModel? namedRover = marsModel
                .Rovers
                .FirstOrDefault(x => x.Name == name);
            return namedRover;
        }

        public MarsModel SetMarsBoundaries(double x, double y)
        {
            Coordinates coordinate = new()
            {
                X = x,
                Y = y,
                Z = 0
            };

            marsModel.Max2DCoordinates = coordinate;
            return marsModel;
        }

        public MarsModel SetMarsBoundaries(double x, double y, double z)
        {
            Coordinates coordinate = new()
            {
                X = x,
                Y = y,
                Z = z
            };

            marsModel.Max2DCoordinates = coordinate;
            return marsModel;
        }
        public MarsModel SetMarsBoundaries(Coordinates coordinates)
        {
            marsModel.Max2DCoordinates = coordinates;
            return marsModel;
        }

        public MarsModel SetMarsBoundaries(Coordinates coordinates2D, Coordinates coordinates3D)
        {
            marsModel.Max2DCoordinates = coordinates2D;
            marsModel.Max3DCoordinates = coordinates3D;
            return marsModel;
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}

