using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

namespace Assignment29
{
public static class Utilities
{
    public static int Add(params int[] numbers)
    {
        int result = 0;
        foreach(int num in numbers)
        {
            result += num;
        }
        return result;
    }
    public static string RepeatString(this string repeatstring, int repeatnum)
    {
        string result = "";
        for(int i = 0; i < repeatnum; i++)
        {
            result += repeatstring;
        }
        return result;
    }
}
}
