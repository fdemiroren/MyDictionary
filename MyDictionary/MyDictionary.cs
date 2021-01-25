using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tkey , TValue>           
    {
        Tkey[] tkeys;
        TValue[] tvalues;

        public MyDictionary()
        {
            tkeys = new Tkey[0];
            tvalues = new TValue[0];
        }

        public void Add(Tkey tkey, TValue tvalue)
        {
            Tkey[] temptkeys = tkeys;
            tkeys = new Tkey[tkeys.Length + 1];
            TValue[] tempvalues = tvalues;
            tvalues = new TValue[tvalues.Length + 1];

            for (int i = 0; i < temptkeys.Length; i++)
            {
                tkeys[i] = temptkeys[i];
            }

            tkeys[tkeys.Length - 1] = tkey;

            for (int i = 0; i < tempvalues.Length; i++)
            {
                tvalues[i] = tempvalues[i];
            }
            tvalues[tvalues.Length - 1] = tvalue;                       
        }

        public int Length
        {
            get { return tkeys.Length; }
        }

        public Tkey[] Tkeys
        {
            get { return tkeys; }
        }

        public TValue[] TValues
        {
            get { return tvalues; }
        }
    }
}
