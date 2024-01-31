using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class ConfigurationManager  //skrbnik
    {
        private List<CarConfiguration> configurations = new List<CarConfiguration>();
        public void AddConfiguration(CarConfiguration configuration) { configurations.Add(configuration); }
        public void DeleteConfiguration(CarConfiguration configuration) { configurations.Remove(configuration); }
        public CarConfiguration GetConfiguration(int index) { return configurations[index]; }

    }
}
