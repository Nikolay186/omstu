using System;

namespace LW1
{
    class CList
    {
        private Bus[] _list;
        private int size;
        private const int DEFAULT_SIZE = 100;

        public CList()
        {
            _list = new Bus[DEFAULT_SIZE];
        }

        public Bus this[int index]
        {
            get
            {
                if ((uint)index >= (uint)size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return _list[index];
            }
            set
            {
                if ((uint)index >= (uint)size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _list[index] = value;
            }
        }

        public void Add(Bus bus)
        {
            if (size == _list.Length)
                ProvideCapacity(size + 1);
            _list[size++] = bus;
        }

        public Bus Find(int critetia)
        {
            foreach (Bus bus in _list)
            {
                if (bus != null && bus.id == critetia)
                    return bus;
            }
            return null;
        }

        public CList FindAll(bool critetia)
        {
            CList res = new CList();
            foreach (Bus bus in _list)
            {
                if (bus != null && bus.onRoute == critetia)
                    res.Add(bus);
            }
            return res;
        }

        public int Size()
        {
            return size;
        }

        private void ProvideCapacity(int minimal)
        {
            if (_list.Length < minimal)
            {
                int newSize = _list.Length == 0 ? DEFAULT_SIZE : _list.Length * 2;

                if ((uint)newSize > int.MaxValue)
                    newSize = int.MaxValue;
                if (newSize < minimal)
                    newSize = minimal;
            }
        }
    }
}
