using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
public class RecursionScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log(FibonacciRecursive(10));
        Debug.Log(FibonacciIterative(10));
        Debug.Log(FibonacciRecursive(30));
        Debug.Log(FibonacciIterative(30));
    }

    int FibonacciRecursive(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    int FibonacciIterative(int n)
    {
        int result = 1;
        if(n == 0)
        {
            result = 0;
        }
        else if (n == 1)
        {
            result = 1;
        }
        else
        {
            int a = 0;
            for (int num = 2; num <= n; num++)
            {
                int temp = a + result;
                a = result;
                result = temp;
            }
        }
        return result;
    }
}
}