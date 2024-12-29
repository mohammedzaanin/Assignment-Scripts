using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
public class TestExtensionMethods : MonoBehaviour
{
    
    void Start()
    {
        Debug.Log(Utilities.Add(1,8,15,9));
        Debug.Log("Hello".RepeatString(3));

    }

}
}
