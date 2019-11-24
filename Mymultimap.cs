using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multimap
{
    class Mymultimap<TKey, TValue> : IDictionary<TKey, List<TValue>>
    {
        Dictionary<TKey, List<TValue>> MyDictionary = new Dictionary<TKey, List<TValue>>();
        public List<TValue> this[TKey key] { get => MyDictionary[key]; set => MyDictionary[key] = value; }

        public ICollection<TKey> Keys { get => MyDictionary.Keys; }

        public ICollection<List<TValue>> Values { get => MyDictionary.Values; }

        public int Count  { get => MyDictionary.Count; }

        public bool IsReadOnly { get => false; }

        public void Add(TKey key, List<TValue> value)
        {
            MyDictionary.Add(key, value);       
        }

        public void Add(KeyValuePair<TKey, List<TValue>> item)
        {
            MyDictionary.Add(item.Key, item.Value);      
        }

        public void Clear()
        {
            MyDictionary.Clear();   
        }

        public bool Contains(KeyValuePair<TKey, List<TValue>> item)
        {
            return (MyDictionary.ContainsKey(item.Key) && MyDictionary.ContainsValue(item.Value));
             
        }

        public bool ContainsKey(TKey key)
        {
            return MyDictionary.ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<TKey, List<TValue>>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<TKey, List<TValue>>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(TKey key)
        {
          return  MyDictionary.Remove(key);       
        }

        public bool Remove(KeyValuePair<TKey, List<TValue>> item)
        {
            if (this.Contains(item))
            {
                MyDictionary.Remove(item.Key);
                return true;
            }
            else
                return
                    false;
        }

        public bool TryGetValue(TKey key, out List<TValue> value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        
        
        
    }
}
