
using poney_valley;

namespace equipement
{
    //Selle
    public class Saddle : IEquipment
    {
        public string Name { get; set; }

        public Saddle(){
            Name = "Saddle";
        }
    }
}