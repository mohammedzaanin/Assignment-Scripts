using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment27
{
public class Callbyrefandvalue : MonoBehaviour
{
    
    void Start()
    {
        int a = 0;
        int b = 0;
        int num;
        Addnumber(a);
        Debug.Log(a);
        Addnumber(ref b);
        Debug.Log(b);
        Assignvalue(out num);
        Debug.Log(num);
    }

    void Addnumber(int number)
    {
        number += 10;
    }
    void Addnumber(ref int number)
    {
        number += 10;
    }
    void Assignvalue(out int number)
    {
        number = 5;
    }
}
}