public interface IGenealogyIterator
{
    Animal Next();
    bool IsDone { get; }
}