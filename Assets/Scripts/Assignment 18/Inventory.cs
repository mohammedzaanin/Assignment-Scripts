using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18{
public class Inventory
{
    private List<string> item_names = new List<string>();
    public void AddItem(string item)
    {
        item_names.Add(item);
    }
    public void ShowItems()
    {
        for(int i = 0; i < item_names.Count; i++)
        {
            Debug.Log(item_names[i]);
        }
    }
    public static Inventory operator +(Inventory inventory_one, Inventory inventory_tow)
    {
        Inventory combined_result = new Inventory();
        combined_result.item_names.AddRange(inventory_one.item_names);
        combined_result.item_names.AddRange(inventory_tow.item_names);
        return combined_result;
    }
}
}
