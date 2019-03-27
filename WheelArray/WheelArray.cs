using System;
using System.Collections;

namespace WheelArray
{
    public class WheelArray<T> : IEnumerator, IEnumerable where T : struct, IConvertible, IComparable, IFormattable
    {
        private T[] _array;
        int _position = -1;
        bool _carousel = false;

        public object Current => _array[_position];

        public WheelArray(T[] array, bool carousel = false)
        {
            _array = array;
            _carousel = carousel;
        }

        public void SetStart(int index)
        {
            if (index >= _array.Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            var newArray = new T[_array.Length];
            var newIndex = 0;

            for (var i = index; i < _array.Length; i++)
            {
                newArray[newIndex] = _array[i];
                newIndex++;
            }

            for (var i = 0; i < index; i++)
            {
                newArray[newIndex] = _array[i];
                newIndex++;
            }

            _array = newArray;
        }

        public T this[int i]
        {
            get
            {
                if (_carousel)
                {
                    i = i >= _array.Length ? i % _array.Length : i;
                }

                return _array[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _array.Length;
        }

        public void Reset()
        {
            _position = 0;
        }
    }
}
