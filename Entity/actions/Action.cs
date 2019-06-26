using System.Collections.Generic;
using System;
namespace poney_valley
{
    public class Action : IAction
    {
        public string Name { get; set; }
        public string Description {get; set; }

        public void Execute(List<IEquipment> equipments)
        {
            Console.WriteLine(this.Name);
        }
    }
}