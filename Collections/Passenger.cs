using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Passenger
    {
        public string LastName{ get; set; }
        public string FirstName{ get; set; }
        public float  Age{ get; set; }
        public string PaxClass{ get; set; }
        public bool   IsPassenger{ get; set; }
        public string Role{ get; set; }
        public bool   Survivor{ get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} was a {PaxClass} and " + (Survivor ? "survived" : "did not survive");
        }

        public Passenger(string lastName, string firstName, float age, string paxClass, bool isPassenger, string role, bool survivor)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Age = age;
            this.PaxClass = paxClass;
            this.IsPassenger = isPassenger;
            this.Role = role;
            this.Survivor = survivor;
        }

        public static List<Passenger> LoadPassengers()
        {
            String fileName = @"C:\Projects\csv\Titanic.csv";

            // Read each line of the file into a string array. 
            // Each element of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(fileName);

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of " + fileName);
            Boolean firstLine = true;
            List<Passenger> passengers = new List<Passenger>();

            foreach (string line in lines)
            {
                //  the first line is a header line, not data. Skip it
                if (firstLine)
                {
                    firstLine = false;
                    continue;
                }
                //  the data is comma separated. create an array of the properties from this line
                string[] props = line.Split(",");

                //  if the age field is empty set it to "0"
                if (props[2].Length == 0) props[2] = "0";

                //  create a passenger from the properties
                Passenger pax = new Passenger(props[0], props[1], float.Parse(props[2]), props[3], props[4].Equals("Passenger"), props[5], props[6].Equals("T"));

                //  add individual passenger to the list of passengers
                passengers.Add(pax);
            }
            return passengers;
        }
    }
}
