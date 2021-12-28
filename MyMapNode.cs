using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class MyMapNode<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;
        
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        public V Get(K Key)
        {
            int position = GetArrayPosition(Key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(Key))
                {
                    return item.Value;


                }
            }
            return default(V);
        }
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList; //if null create instance of it 

            }
            return linkedList;

        } 



        public void Add( K key, V value)
            {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value};
            linkedList.AddLast(item);

        }   
        /*
        public void Remove (K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemfound = false;
            KeyValue<K, V> founditems = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemfound = true;
                    founditems = item;

                }
            }
            if (itemfound)
            {
                linkedList.Remove(founditems);
            }
        }

        */
    }
    
    public struct KeyValue<K, V> 
    {
        public K Key { get; set; }
        public V Value { get; set; }
    }



    
}
