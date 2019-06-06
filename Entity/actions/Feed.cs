using System;
namespace poney_valley
{
    public class Feed : IAction
    {
        public override void Execute(List<IEquipement> equipments)
        {
            Console.WriteLine("nourir");
        }
    }
}