using InterpreterCSharp.Source.domain.statements;
using InterpreterCSharp.Source.exceptions.domain;

namespace InterpreterCSharp.Source.domain.adts
{
    public class ArrayStack : IStack<IStatement>
    {
        private const int Capacity = 100;
        private readonly IStatement[] _array;
        private int _size;

        public ArrayStack()
        {
            _array = new IStatement[Capacity];
            _size = 0;
        }

        public void Push(IStatement element)
        {
            if (_size >= Capacity)
            {
                throw new ArrayOverflowException();
            }

            _array[_size] = element;
            _size++;
        }

        public IStatement Pop()
        {
            if (_size <= 0)
            {
                throw new EmptyStackException();
            }

            _size--;
            var e = _array[_size];
            _array[_size] = null;
            return e;
        }

        public bool IsEmpty()
        {
            return (_size == 0);
        }

        public override string ToString()
        {
            var output = "";
            for (var i = 0; i < _size; i++)
            {
                output += _array[_size].ToString() + "\n";
            }
            return output;
        }
    }
}