using poney_valley;
using System.Collections.Generic;
namespace Genealogy {

    public class GenealogyTree
    {
        private Animal animal { get; set; }
        private List<Animal> flatTree = new List<Animal>();

        public GenealogyIterator CreateIterator(Animal animal)
        {
            this.animal = animal;
            GenerateFlatTree(animal);
            return new GenealogyIterator(this);
        }

        public int Count
        {
            get => flatTree.Count;
        }

        private void GenerateFlatTree(Animal animal)
        {
            if (animal == null) { return; }
            flatTree.Add(animal);
            if (animal.Parents.Count > 0)
                GenerateFlatTree(animal.Parents[0]);
            if (animal.Parents.Count > 1)
                GenerateFlatTree(animal.Parents[1]);
        }

        public Animal this[int index]
        {
            get => flatTree[index];
        }
    }
}