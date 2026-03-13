using System;
using System.Collections.Generic;
using System.Text;

namespace sharp_lessons4
{
    public class Warehouse
    {
        private string[] _items;

        public event Action<int, string> OnItemChanged;

        public Warehouse()
        {
            _items = new string[10];
        }

        public string this[int index]
        {
            get
            {
                return _items[index];
            }
            set
            {
                _items[index] = value;
                OnItemChanged?.Invoke(index, value);
            }
        }

        public int Size => _items.Length;
    }
}
