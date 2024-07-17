using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3Stack_Queue
{
    public class Queue<T>
    {
        private T[] _array;
        private int _size;
        private int _head;

        public Queue()
        {
            _array = new T[] { };
            _size = 0;
            _head = 0;
        }

        public void Enqueue(T value)
        {
            T[] newArray = new T[_size + 1];
            Array.Copy(_array, newArray, _size);
            _array = newArray;
            _array[_size] = value;
            _size++;
        }

        public T Dequeue()
        {
            if(_size == 0)
            {
                Console.Write("Queue is empty ");
                return default;
            }
            T first = _array[_head];
            _array[_head] = default;
            _head++;
            _size--;
            return first;
        }
    }
}
