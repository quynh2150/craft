using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class InputArray<T>: ICollection<T> where T:IComparable<T>
    {
        T[] _input;

        public int Count
        {
            get
            {
                return ((ICollection<T>)_input).Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return ((ICollection<T>)_input).IsReadOnly;
            }
        }

        public void Add(T item)
        {
            ((ICollection<T>)_input).Add(item);
        }

        public void Clear()
        {
            ((ICollection<T>)_input).Clear();
        }

        public bool Contains(T item)
        {
            return ((ICollection<T>)_input).Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((ICollection<T>)_input).CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((ICollection<T>)_input).GetEnumerator();
        }

        public T Member(int index)
        {
            return _input.ElementAt(index);
        }

        public bool Remove(T item)
        {
            return ((ICollection<T>)_input).Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ICollection<T>)_input).GetEnumerator();
        }
    }
}
