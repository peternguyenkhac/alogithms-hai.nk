using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3Stack_Queue
{
    public class Stack<T>
    {
        private T[] _array;
        private int _size;

        public Stack()
        {
            _array = new T[] { };
            _size = 0;
        }

        public void Push(T value)
        {
            T[] newArray = new T[_size + 1];
            Array.Copy(_array, newArray, _size);
            _array = newArray;
            _array[_size] = value;
            _size++;
        }

        public T Pop()
        {
            if( _size == 0 )
            {
                Console.Write("Stack is empty ");
                return default;
            }
            T last = _array[_size - 1];
            _array[_size - 1] = default;
            _size--;
            return last;
        }
    }
}
