namespace poney_valley
{
    public abstract class Animal 
    {
        private int livePoint;
        public string Name {get;};
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
            Actions.AddAll(actions);
        }

        public void GetLife()
        {
            Console.WriteLine("Point de vie de "+ this.Name +" => "+ this.livePoint +" PV" );
        }

        public void StartActions()
        {
            Actions.foreach(action => action.Execute(this.Equipments));
        }
    }
}