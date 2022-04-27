using System;
using doonamis_technical_test.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace doonamis_technical_test.Models
{
    public class RoverService : IRoverService
    {
        public RoverService()
        {
        }

        public Task<IActionResult> ChangeOrientation()
        {
            throw new NotImplementedException();
        }

        public Task<Coordinates> GetCoordinates()
        {
            throw new NotImplementedException();
        }

        public Task<OrientationEnum> GetOrientation()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> MoveForward()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> ResetCoordinates()
        {
            throw new NotImplementedException();
        }
    }
}
