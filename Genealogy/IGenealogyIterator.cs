using poney_valley;
namespace Genealogy {
    public interface IGenealogyIterator
    {
        public Animal Next();
        public bool IsDone { get; }
    }
}