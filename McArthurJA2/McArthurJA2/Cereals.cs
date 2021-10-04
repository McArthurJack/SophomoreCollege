using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McArthurJA2
{
    //Creating an Enumerable class to be able to run LINQ commands
    class Cereals : IEnumerable<Cereal>
    {
        //List of the cereals found in the CSV file
        public List<Cereal> cereals = new List<Cereal>();

        //Sets the cereals list to the CSV file when created
        public Cereals()
        {
            dataCollection(cereals);
        }

        //Searches through the CSV file and collects the data to turn them into Cereal classes then adds them to cereals List
        private List<Cereal> dataCollection(List<Cereal> cereals)
        {
            try
            {
                StreamReader reader = new StreamReader("Cereal.csv");

                string line = reader.ReadLine();

                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    cereals.Add(new Cereal(data[0], data[1][0], data[2][0], Int32.Parse(data[3]), Int32.Parse(data[4]), Int32.Parse(data[5]), Int32.Parse(data[6]), float.Parse(data[7]),
                        float.Parse(data[8]), float.Parse(data[9]), float.Parse(data[10]), float.Parse(data[11]), float.Parse(data[12]), float.Parse(data[13]), float.Parse(data[14]),
                        float.Parse(data[15])));
                }
            }
            catch (FileNotFoundException e)
            {

            }

            return cereals;
        }

        //Enumerator class to return the cereal found when running a LINQ query
        public IEnumerator<Cereal> GetEnumerator()
        {
            foreach (var cereal in cereals)
            {
                yield return cereal;
            }
        }

        //Necessary to make an IEnumerable Class
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
