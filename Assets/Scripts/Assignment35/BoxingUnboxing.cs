using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
public class BoxingUnboxing : MonoBehaviour
{
    
    
    void Start()
    {
       int health = 100;
       object box_health = health;
       int unbox_health = (int) box_health;
       Debug.Log(health);
       Debug.Log(box_health);
       Debug.Log(unbox_health);
       unbox_health +=300;
       Debug.Log(unbox_health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}