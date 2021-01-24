using System;
using System.Linq;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        private TKey[] _key;
        private TValue[] _value;

        private TKey[] _tempKeys;
        private TValue[] _tempValues;

        public MyDictionary()
        {
            _key = new TKey[0];
            _value = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            _tempKeys = _key;
            _key = new TKey[_key.Length + 1];
            _tempValues = _value;
            _value = new TValue[_value.Length + 1];
            for (int i = 0; i < _tempValues.Length; i++)
            {
                _key[i] = _tempKeys[i];
                _value[i] = _tempValues[i];
            }
            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }

        public TKey[] Keys
        {
            get
            {
                return _key;
            }
        }

        public TValue[] Values
        {
            get
            {
                return _value;
            }
        }

        public int Count
        {
            get
            {
                return _key.Length;
            }
        }

        private TKey tempKey;
        private TValue tempValue;
        public void Insert(int index, TKey key, TValue value)
        {
            _tempKeys = _key;
            _key = new TKey[_key.Length + 1];
            _tempValues = _value;
            _value = new TValue[_value.Length + 1];
            for (int i = 0; i < _key.Length; i++)
            {
                if (i == index)
                {
                    _key[i] = key;
                    _value[i] = value;
                    
                }
                else if (i>index)
                {
                    _key[i] = _tempKeys[i - 1];
                    _value[i] = _tempValues[i - 1];
                }
                else
                {
                    _key[i] = _tempKeys[i];
                    _value[i] = _tempValues[i];
                }
            }
        }

        public void DeleteByKey(TKey key)
        {
            _tempKeys = _key;
            _key = new TKey[_key.Length - 1];
            for (int i = 0; i < _key.Length; i++)
            {
                if (i >= Array.IndexOf(_tempKeys, key))
                {
                    _key[i] = _tempKeys[i + 1];
                }
                else
                {
                    _key[i] = _tempKeys[i];
                }
                
            }
        }
    }
}