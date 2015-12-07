using InterpreterCSharp.Source.exceptions.domain;

namespace InterpreterCSharp.Source.domain.adts
{
    public class ArrayDictionary : IDictionary<string, int>
    {
        private const int Capacity = 100;
        private readonly string[] _keys;
        private readonly int[] _values;
        private int _size;

        public ArrayDictionary()
        {
            _keys = new string[Capacity];
            _values = new int[Capacity];
            _size = 0;
        }

        public void Put(string key, int value)
        {
            if (_size >= Capacity)
            {
                throw new ArrayOverflowException();
            }

            var i = 0;
            while (i < _size)
            {
                if (_keys[i] == key)
                {
                    break;
                }
                i++;
            }

            _keys[i] = key;
            _values[i] = value;

            if (i == _size)
            {
                _size++;
            }
        }

        public int Get(string key)
        {
            var i = 0;
            while (i < _size)
            {
                if (_keys[i] == key)
                {
                    break;
                }
                i++;
            }

            if (i == _size)
            {
                throw new KeyNotFoundException();
            }
            return _values[i];
        }

        public override string ToString()
        {
            var output = "";
            for (var i = 0; i < _size; i++)
            {
                output += _keys[_size] + " => " + _values[_size] + "\n";
            }
            return output;
        }
    }
}