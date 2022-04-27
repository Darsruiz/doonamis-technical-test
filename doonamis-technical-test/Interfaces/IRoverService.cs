using doonamis_technical_test.Models;
using Microsoft.AspNetCore.Mvc;

namespace doonamis_technical_test.Interfaces
{
    public interface IRoverService
	{
		public Task<Coordinates> GetCoordinates();

		public Task<OrientationEnum> GetOrientation();

		public Task<IActionResult> MoveForward();

		public Task<IActionResult> ChangeOrientation();

		public Task<IActionResult> ResetCoordinates(); 
	}
}

