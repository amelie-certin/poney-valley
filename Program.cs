
using System;
using Genealogy;
using System.Collections.Generic;
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
            
            DisplayMenu();


        }

        private static void DisplayMenu()
        {
            var running = true;
            while(running)
            {
                Console.WriteLine("1 - Afficher la famille d'un Poney");
                Console.WriteLine("2 - Afficher les informations d'un Poney");
                Console.WriteLine("3 - Ajouter une action à un Poney");
                Console.WriteLine("4 - Executer les actions d'un Poney");
                Console.WriteLine("5 - Equiper un Poney");
                Console.WriteLine("6 - Quitter");
                int choice = Int32.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        // animal.DisplayFamilly();
                        break;
                    case 2:
                        running = false;
                        break;
                    case 3:
                    running = false;
                        break;
                    case 4:
                    running = false;
                        break;
                    case 5:
                    running = false;
                        break;
                    case 6:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Retente ta chance");
                        break;
                }
            }
        }

        private static Animal ChoosePoney(PoneyFarm farm)
        {
            foreach (var item in farm.Animals)
            {
                Console.WriteLine();
            }
            return null;
            
        }

        // private static void DisplayFamilly(Animal animal) {
        //     GenealogyTree tree = new GenealogyTree();
        //     GenealogyIterator iterator = tree.CreateIterator(animal);
        //     var item = iterator.First();
        //     while (item != null)
        //     {
        //         Console.WriteLine(item.GetLife());
        //         item.StartActions();
        //         item = iterator.Next();
        //     }
        // }
    }
}
