using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Multiplication Table for 5 (from 1 to 10)
    void Start()
    {
        Debug.Log("Multiplication Table for 5");
        Debug.Log("---------------------------------------------");
        int res;
        for (int i = 1; i <= 10; i++)
        {
            res = Multiply(i,5);
            Debug.Log(5 + " x " + i + " = " + res);
        }
        Debug.Log("---------------------------------------------");
    }

    int Multiply(int n1 , int n2){
        return n1 * n2;
    }
    
}
