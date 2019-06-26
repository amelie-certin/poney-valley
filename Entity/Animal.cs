using System;
using System.Collections.Generic;
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
        }

        public void AppendAction(IAction action)
        {
            Actions.Add(action);
        }

        public void AppendActions(List<IAction> actions)
        {
            Actions.AddRange(actions);
        }

        public void GetLife()
        {
            Console.WriteLine("Point de vie de "+ this.Name +" => "+ this.livePoint +" PV" );
        }

        public void StartActions()
        {
            Actions.ForEach(action => action.Execute(Equipments));
        }
    }
}