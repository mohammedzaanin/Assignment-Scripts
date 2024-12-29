using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
public class BasicsScript : MonoBehaviour
{
    
    void Start()
    {
        var number = 5;
        var string_text = "";
        var bool_condition = true;
        string result = number % 2 == 0 ? $"The number {number} is even." : $"The number {number} is odd.";
        Debug.Log(result);
        Debug.Log("The current date : " + DateTime.Now.ToString("yyyy-MM-dd"));
        Debug.Log("The current time : " + DateTime.Now.ToString("HH:mm:ss"));
        Debug.Log("the current day : " + DateTime.Now.Day + " - " + DateTime.Now.DayOfWeek);
    }

}
}