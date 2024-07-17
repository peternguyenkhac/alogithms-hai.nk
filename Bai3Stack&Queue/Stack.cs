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

        //thêm 1 item lên trên cùng (cuối mảng)
        public void Push(T value)
        {
            T[] newArray = new T[_size + 1];        // tạo mảng mới có size + 1
            Array.Copy(_array, newArray, _size);    // copy mảng cũ qua mảng mới
            _array = newArray;                      // tham chiếu mảng cũ đến mảng mới
            _array[_size] = value;                  // thêm item vào cuối mảng
            _size++;                                // + 1 kích thước
        }

        //lấy ra item ở trên cùng (cuối mảng)
        public T Pop()
        {
            if( _size == 0 )                        //kiểm tra stack rỗng 
            {
                Console.Write("Stack is empty ");
                return default;
            }
            T last = _array[_size - 1];             // lấy ra item ở cuối mảng
            _array[_size - 1] = default;            // set giá trị cuối trong mảng = null
            _size--;                                // - 1 kích thước
            return last;                            // trả về item
        }
    }
}
