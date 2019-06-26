using poney_valley;
namespace equipement
{
    //Tapis de selle
    public class SaddleBlanket : IEquipment
    {
        public string Name { get; set; }

        public SaddleBlanket(){
            Name = "SaddleBlanket";
        }

    }
}