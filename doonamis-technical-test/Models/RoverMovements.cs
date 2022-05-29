using System;
namespace doonamis_technical_test.Models
{
    public class RoverMovements
    {
        public RoverMovements()
            {
            MovementsDone = new List<char>();
            BlockedMovements = new List<char>();
        }
        public List<char> MovementsDone { get; set; }
        public List<char> BlockedMovements { get; set; }
    }
}

