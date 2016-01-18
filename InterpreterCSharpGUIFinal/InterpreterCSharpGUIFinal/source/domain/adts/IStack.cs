namespace InterpreterCSharp.Source.domain.adts
{
    public interface IStack<E>
    {
        void Push(E element);
        E Pop();
        bool IsEmpty();
        string ToString();
    }
}