using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
public class BuiltInDelegatesExample : MonoBehaviour
{
    Action logMessage;
    Func<int, int> square;
    Predicate<int> isEven;
    void Start()
    {
        logMessage = ()=> Debug.Log("Hello From Mohammed Alzaanin PC");
        logMessage();
        square = (int num)=> num * num;
        Debug.Log($"Square: {square(5)}");
        isEven = (int num)=> num%2 == 0 ? true : false;
        Debug.Log($"Is 4 even? {isEven(4)}"); 
    }

    void Update()
    {
        
    }
}
}