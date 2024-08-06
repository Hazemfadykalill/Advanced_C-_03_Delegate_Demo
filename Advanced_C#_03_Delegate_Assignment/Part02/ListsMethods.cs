using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__03_Delegate_Assignment.Part02
{
    public class ListsMethods<T>
    {
        #region Attributes
        T[] _items;
        int _count;
        const int DefaultCapacity = 4;  
        #endregion

        #region Constructors
        public ListsMethods()
        {
            _items = new T[DefaultCapacity];
            _count = 0;
        }
        #endregion

        #region Property
        public int Count => _count;

        public int Capacity => _items.Length; 
        #endregion
        #region Lists Method
        #region Exist
        public bool Exists(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            for (int i = 0; i < _count; i++)
            {
                if (match(_items[i]))
                {
                    return true;
                }
            }
            return false;
        }



        #endregion

        #region Find
        public T Find(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            for (int i = 0; i < _count; i++)
            {
                if (match(_items[i]))
                {
                    return _items[i];
                }
            }
            return default(T);
        }
        #endregion

        #region Find All

        public List<T> FindAll(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            List<T> result = new List<T>();
            for (int i = 0; i < _count; i++)
            {
                if (match(_items[i]))
                {
                    result.Add(_items[i]);
                }
            }
            return result;
        }
        #endregion

        #region Foreach
        public void ForEach(Action<T> action)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            for (int i = 0; i < _count; i++)
            {
                action(_items[i]);
            }
        }

        #endregion

        #region TrueForAll
        public bool TrueForAll(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            for (int i = 0; i < _count; i++)
            {
                if (!match(_items[i]))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region FindLast
        public T FindLast(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            for (int i = _count - 1; i >= 0; i--)
            {
                if (match(_items[i]))
                {
                    return _items[i];
                }
            }
            return default(T);
        }

        #endregion

        #region Find Last Index
        public int FindLastIndex(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            for (int i = _count - 1; i >= 0; i--)
            {
                if (match(_items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public int FindLastIndex(int startIndex, Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            if (startIndex < 0 || startIndex >= _count)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            for (int i = startIndex; i >= 0; i--)
            {
                if (match(_items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public int FindLastIndex(int startIndex, int count, Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            if (startIndex < 0 || startIndex >= _count)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (count < 0 || startIndex - count + 1 < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            for (int i = startIndex; i >= startIndex - count + 1; i--)
            {
                if (match(_items[i]))
                {
                    return i;
                }
            }
            return -1;
        }


        #endregion


        #endregion



    }
}
