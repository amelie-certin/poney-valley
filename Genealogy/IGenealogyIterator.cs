using poney_valley;
namespace Genealogy {
    public interface IGenealogyIterator
    {
        Animal Next();
        Animal First();

        bool IsDone { get; }
    }
}