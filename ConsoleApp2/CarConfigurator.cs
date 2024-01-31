using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class CarConfigurator//memento
    {
        public string Model { get; private set; }
        private List<Equipment> additionalEquipment = new List<Equipment>();
        public void AddExtra(Equipment package) { additionalEquipment.Add(package); }
        public void Remove(Equipment package) { additionalEquipment.Remove(package); }
        public void Rollback(CarConfiguration configuration)
        {
            Model = configuration.GetModel();
            additionalEquipment.Clear();
            additionalEquipment.AddRange(configuration.AddPackages());
        }
        public CarConfigurationStore()
        {
            return new CarConfguration(Model, additionalEquipment);
        }
    }
}
