using poney_valley;
using System.Collections.Generic;

namespace Genealogy {
    public class GenealogyIterator : IGenealogyIterator
    {
        private int current;
        private GenealogyTree tree;

        public GenealogyIterator(GenealogyTree tree) 
        {
            this.tree = tree;
            this.current = 0;
        }
        
        public bool IsDone {
            get => current >= tree.Count;
        }

        public Animal First()
        {
            return tree[0];
        }

        public Animal Next()
        {
            current++;
            if(!IsDone)
            {
                return tree[current];
            }
            return null;
        }
    }
}