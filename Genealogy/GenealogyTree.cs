using poney_valley;
using System.Collections.Generic;
namespace Genealogy {

    class GenealogyTree
    {
        private Animal animal { get; }
        private List<Animal> flatTree;

        public GenealogyIterator CreateIterator()
        {
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
            GenerateFlatTree(animal.Parents[0]);
            GenerateFlatTree(animal.Parents[1]);
        }

        public object this[int index]
        {
            get => flatTree[index];
        }
    }
}