using System;
using System.Collections.Generic;
using Genealogy;
namespace poney_valley
{
    public abstract class Animal 
    {
        public List<Animal> Parents { get; set; }
        private int livePoint;
        public string Name {get;}
        public List<IAction> Actions {get; set;}
        public List<IEquipment> Equipments {get; set;}
    
        public Animal(string name, int livePointStart)
        {
            this.Name = name;
            this.livePoint = livePointStart;
            this.Parents = new List<Animal>();
            this.Actions = new List<IAction>();
            this.Equipments = new List<IEquipment>(); 
        }

        public void AppendAction(IAction action)
        {
            Actions.Add(action);
        }

        public void AppendActions(List<IAction> actions)
        {
            Actions.AddRange(actions);
        }

        public String GetLife()
        {
            return "Point de vie de "+ this.Name +" => "+ this.livePoint +" PV";
        }

        public void StartActions()
        {
            Actions.ForEach(action => action.Execute(Equipments));
        }

        public void DisplayFamilly() {
            GenealogyTree tree = new GenealogyTree();
            GenealogyIterator iterator = tree.CreateIterator(this);
            var item = iterator.First();
            while (item != null)
            {
                Console.WriteLine(item.GetLife());
                item = iterator.Next();
            }
        }
    }
}