using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18{
public class GameContainer<T>
{
    public T Item;
    public void SetItem(T item)
    {
        this.Item = item;
    }
    public T GetItem(){
        return Item;
    }
}
}