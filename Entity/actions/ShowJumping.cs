using System;
namespace poney_valley
{
    public class ShowJumping : IAction
    {
        public override void Execute(List<IEquipement> equipments)
        {
            Console.WriteLine("Jump !!!");
        }
    }
}