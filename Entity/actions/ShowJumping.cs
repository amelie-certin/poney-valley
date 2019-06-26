using System;
using poney_valley;
using System.Collections.Generic;
namespace poney_valley
{
    public class ShowJumping : IAction
    {
        public void Execute(List<IEquipment> equipments)
        {
            Console.WriteLine("Jump !!!");
        }
    }
}