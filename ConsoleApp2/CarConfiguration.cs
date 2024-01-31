using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class CarConfiguration//originator
        //radio sam uz pomoc chatGPTa u zadnji cas pa mi nije jasno sta se desava ovdje
    {
        private string model;
        private List<Equipment> additionalEquipment;

        public CarConfiguration(string model,List<Equipment> additionalequipment)
        {
            this.model = model;
            this.additionalEquipment = AddExtra(additionalEquipment);
        }

        public string GetModel() { return model; }
        public List<Equipment> GetPackages() { return new List<Equipment>}(additionalEquipment);

        
        public CarConfiguration SaveToMemento()
        {
            return new CarConfiguration(model, additionalEquipment);
        }
        public void RestoreFromMemento(CarConfguration memento)
        {
            model = memento.GetModel();
            additionalEquipment = new List<Equipment>(memento.GetPackages());
        }
    }
}
