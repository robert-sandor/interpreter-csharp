namespace InterpreterCSharp.Source.domain.adts
{
    public interface IDictionary<K, V>
    {
        void Put(K key, V value);
        V Get(K key);
        string ToString();
    }
}