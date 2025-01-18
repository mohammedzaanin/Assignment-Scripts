using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
public delegate void MathOperation(int number);
public class MulticastDelegateExample : MonoBehaviour
{
    MathOperation operation;
    void Start()
    {
        operation += DoubleNumber;
        operation += SquareNumber;
        operation += CubeNumber;
        operation(5);
    }

    void Update()
    {
        
    }
    void DoubleNumber(int number)
    {
        Debug.Log("Double: " + (number + number));
    }
    void SquareNumber(int number)
    {
        Debug.Log("Square: " + (number * number));
    }
    void CubeNumber(int number)
    {
         Debug.Log("Cube: " + (number * number * number));
    }
}
}