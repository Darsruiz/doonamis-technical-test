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

		public string Name { get; set; }
        public Coordinates Coordinates { get; set; }
	}
}

