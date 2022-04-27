using System;
using doonamis_technical_test.Interfaces;
using doonamis_technical_test.Models;

namespace doonamis_technical_test.Services
{
	public class MarsService : IMarsService
    {
		public MarsService()
        {
		}

        public Task<bool> CheckBoundaries()
        {
            throw new NotImplementedException();
        }

        public Task<MarsModel> GetMars()
        {
            throw new NotImplementedException();
        }

        public Task<HashSet<RoverModel>> GetRoverPosition()
        {
            throw new NotImplementedException();
        }

        public Task<Coordinates> GetRoverPositionByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<MarsModel> SetMarsBoundaries()
        {
            throw new NotImplementedException();
        }
    }
}

