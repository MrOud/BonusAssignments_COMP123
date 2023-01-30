namespace Bonus2
{
	internal class Program
	{
		/* Bonus 2
			Kris Oud - 301274712 - COMP123_403 W23
			Jan 30, 2023 */
		static void Main(string[] args) {
			//Make our list of 5 planes, one with default constructor
			List<Plane> fleet = new List<Plane>();
			fleet.Add(new Plane());
			fleet.Add(new Plane("Boeing", "DC-10", 150, "passenger", "N3452"));
			fleet.Add(new Plane("Tesla", "Cyber Plane", 420, "cargo", "T1908"));
			fleet.Add(new Plane("Avro", "Arrow", 2, "military", "CF-133"));
			fleet.Add(new Plane("Skunkworx", "Notaufo", 375, "military", "A51-SHH"));

			//ToString like it ain't no thing....
			foreach (Plane plane in fleet) {
				Console.WriteLine(plane.ToString());
			}
			Console.WriteLine(); //Spacious!

			//Test the capactiy
			Random random = new Random();
			foreach (Plane plane in fleet) {
				//Inform our user of what we're testing
				Console.WriteLine($"Testing: {plane.Manufactory} {plane.Model}");
				Console.WriteLine($"Capacity: {plane.Capacity}");
				//Get a range of pass/fail tests
				int testMin = plane.Capacity - 10;
				int testMax = plane.Capacity + 10;
				//and test them...
				for (int i = 0; i < 5; i++) {
					int testCapacity = random.Next(testMin, testMax);
					Console.WriteLine($"Testing {testCapacity} -> {plane.HasCapactiy(testCapacity)}");
				}
				Console.WriteLine(); //Avoid the ugly wall o' text effect...
			}
		}
	}

	internal class Plane {

		//Properties - public get, private set ... secure(ish) & easy
		public string Manufactory { get; private set; }
		public string Model { get; private set; }
		public int Capacity { get; private set; }
		public string Type { get; private set; }
		public string SerialNumber { get; private set; }


		public Plane() {
			//I know I dont "need" all the this.'s but I like to be explicity and it's fun to say "this dot" in my head as I type...
			this.Manufactory = "unknown";
			this.Model = "unknown";
			this.Capacity = 0;
			this.Type = "unassigned";
			this.SerialNumber = "00000";
		}

		public Plane(string manufactory, string model, int capacity, string type, string serialNumber) {
			this.Manufactory = manufactory;
			this.Model = model;
			this.Capacity = capacity;
			this.Type = type;
			this.SerialNumber = serialNumber;
		}

		public bool HasCapactiy(int checkCapacity) {
			return this.Capacity >= checkCapacity;
		}

		public override string ToString() {
			return $"Manufactory: {this.Manufactory}, Model: {this.Model}, Capacity: {this.Capacity}, Type: {this.Type}, Serial Number: {this.SerialNumber}";
		}
	}
}