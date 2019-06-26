
using poney_valley;
using System.Collections.Generic;
namespace poney_valley
{
    public interface IAction
    {
        void Execute(List<IEquipment> equipments);
    }
}