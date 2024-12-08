using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Ass18
{
    public class Inventory
    {
        private List <string> items = new List<string>();

        public void AddItem(string item)
        {
            items.Add(item);
        }

        public void ShowItems()
        {
            foreach (string item in items)
            {
                Debug.Log(item);
            }
        }


        public static Inventory operator + (Inventory inv1, Inventory inv2)
        {
            Inventory combin = new Inventory();
            combin.items.AddRange(inv1.items);
            combin.items.AddRange(inv2.items);
            return combin;
        }
    }
}
