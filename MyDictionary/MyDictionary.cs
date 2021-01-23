using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] _keys;
        TValue[] _values;
        TKey[] _tempKeys;
        TValue[] _tempValue;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            _tempKeys = _keys;
            _tempValue = _values;
            _keys = new TKey[_keys.Length + 1];
            _values = new TValue[_keys.Length + 1];
            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i];
                _values[i] = _tempValue[i];
            }
            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;

        }

        public int Count
        {
            get { return _keys.Length; }
        }

    }
}
