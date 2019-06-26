
using poney_valley;
namespace equipement
{
    //Longe
    public class Tether : IEquipment
    {
        public string Name { get; set; }

        public Tether() {
            this.Name = "Tether";
        }

    }
}