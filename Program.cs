
using System;
using Genealogy;
using System.Collections.Generic;
using equipement;
namespace poney_valley
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm PoneyFarm = FarmFactory.GetFarm();
            
            PoneyFarm.Animals.Add(new Unicorn("Claudia", 47));
            PoneyFarm.Animals.Add(new Unicorn("Rhino", 77));
            Unicorn babyUni = new Unicorn("Serina", 77);
            babyUni.Parents = PoneyFarm.Animals;
            PoneyFarm.Animals.Add(babyUni);
            
            PoneyFarm.Animals.Add(new Shetland("Mini", 89));
            PoneyFarm.Animals.Add(new Shetland("Toto", 5));
            Shetland babyPoney = new Shetland("Alphonse", 66);
            babyPoney.Parents = PoneyFarm.Animals.GetRange(3,2);
            PoneyFarm.Animals.Add(babyPoney);
            
            DisplayMenu(PoneyFarm);


        }

        private static void DisplayMenu(Farm farm)
        {
            var running = true;
            while(running)
            {
                Console.WriteLine("0 - Afficher tous les Poney");
                Console.WriteLine("1 - Afficher la famille d'un Poney");
                Console.WriteLine("2 - Afficher les informations d'un Poney");
                Console.WriteLine("3 - Ajouter une action à un Poney");
                Console.WriteLine("4 - Executer les actions d'un Poney");
                Console.WriteLine("5 - Equiper un Poney");
                Console.WriteLine("6 - Afficher les Equipement d'un Poney");
                Console.WriteLine("7 - Quitter");
                string[] choice = Console.ReadLine().Split(" ");
                Animal animal = null;
                if (choice.Length > 1 || choice[0] != "0" && choice[0] != "7")
                    animal = RetrievePoneyByName(choice[1], farm);
                

                switch(Int32.Parse(choice[0]))
                {
                    case 0:
                        farm.DisplayAll();
                        break;
                    case 1:
                        animal.DisplayFamilly();
                        break;
                    case 2:
                        Console.WriteLine(animal.GetLife());
                        break;
                    case 3:
                        appendAction(animal, choice[2]);
                        break;
                    case 4:
                        animal.StartActions();
                        break;
                    case 5:
                        appendEquipment(animal, choice);
                        break;
                    case 6:
                        animal.DisplayEquipment();
                        break;
                    case 7:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Retente ta chance");
                        break;
                }
            }
        }

        private static Animal RetrievePoneyByName(string name, Farm farm)
        {
            return farm.Animals.Find( t => t.Name.Equals(name));   
        }

        private static void appendEquipment(Animal animal, string[] choice){
            IEquipment equipment = null;
            if ("Bridle".Equals(choice[2]))
                equipment = new Bridle();
            else if ("Halter".Equals(choice[2]))
                equipment = new Halter();
            else if ("Saddle".Equals(choice[2]))
                equipment = new Saddle();
            else if ("Saddle Blanket".Equals(choice[2]+" "+choice[3]))
                equipment = new SaddleBlanket();
            else if ("Tether".Equals(choice[2]))
                equipment = new Tether();

            animal.Equipments.Add(equipment);
        }

        private static void appendAction(Animal animal, String action){
            if ("Feed".Equals(action))
                animal.AppendAction(new Feed());
            else if ("Jump".Equals(action))
                animal.AppendAction(new ShowJumping());
        }
    }
}
