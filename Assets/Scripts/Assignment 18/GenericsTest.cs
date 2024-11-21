using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18{
public class GenericsTest : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GameContainer<string> something = new GameContainer<string>();
        something.SetItem("Healing Potion");
        Debug.Log("Stored item: " + something.GetItem());
        Debug.Log(GameUtils.DescribeItem(something.GetItem()));
    }

}
}
