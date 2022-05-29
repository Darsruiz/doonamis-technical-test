using System;
using System.Collections.Generic;
using System.Diagnostics;
using doonamis_technical_test.Interfaces;
using doonamis_technical_test.Models;

namespace doonamis_technical_test.Services
{
    public class MarsService : IMarsService
    {
        private MarsModel marsModel;

        public MarsService()
        {
            marsModel = Globals.Mars;
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
        public Coordinates Get3DBoundaries()
        {
            return marsModel.Max3DCoordinates;
        }

        public MarsModel GetMars()
        {
            return marsModel;
        }

        public HashSet<RoverModel> GetRover()
        {
            return marsModel.Rovers;
        }

        public RoverModel? GetRoverByName(string name)
        {
            RoverModel? namedRover = marsModel
                .Rovers
                .FirstOrDefault(x => x.Name == name);
            return namedRover;
        }

        public MarsModel SetMarsBoundaries(Coordinates coordinates)
        {
            marsModel.Max2DCoordinates = coordinates;
            return marsModel;
        }

        public MarsModel SetMars3DBoundaries(Coordinates coordinates3D)
        {
            marsModel.Is3D = true;
            marsModel.Max3DCoordinates = coordinates3D;
            return marsModel;
        }

        public MarsModel ResetMars()
        {
            Globals.Mars = new();
            marsModel = Globals.Mars;
            return marsModel;
        }
    }
}

