namespace InterpreterCSharp.Source.domain.adts
{
    public interface IList<E>
    {
        void Add(E element);
        void Update(int index, E element);
        E Get(int index);
        int Size();
        string ToString();
    }
}