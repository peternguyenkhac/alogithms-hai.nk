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

        //Thêm item vào cuối mảng ~ tương tự stack
        public void Enqueue(T value)
        {
            T[] newArray = new T[_size + 1];    
            Array.Copy(_array, newArray, _size);
            _array = newArray;
            _array[_size] = value;
            _size++;
        }

        //Lấy ra item ở đầu mảng
        public T Dequeue()
        {
            if(_size == 0)                          // kiểm tra queue rỗng
            {
                Console.Write("Queue is empty ");
                return default;
            }
            T first = _array[_head];                // lấy ra item ở đầu
            _array[_head] = default;                // set giá trị đầu trong mảng = null (dựa trên head)
            _head++;                                // tăng head lên 1 (cho những lần tìm kiếm sau)
            _size--;                                // - 1 kích thước
            return first;                           // return item
        }
    }
}
