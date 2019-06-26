using System;
using System.Collections.Generic;
using poney_valley;

namespace poney_valley
{
    public class Feed : IAction
    {
        public void Execute(List<IEquipment> equipments)
        {
            Console.WriteLine("nourir");
        }
    }
}