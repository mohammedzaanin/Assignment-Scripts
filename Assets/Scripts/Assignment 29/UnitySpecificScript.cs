using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
public class UnitySpecificScript : MonoBehaviour
{
    GameObject targetObject;
    GameObject jokerObject;
    Light lightObject;
   void OnEnable()
   {
    print("GameObject Enabled");
   }
   void OnDisable()
   {
    print("GameObject Disabled");
   }
   void Start()
   {
    print("Game started!");
    targetObject = GameObject.Find("TargetObject");
    if(targetObject != null)
    {
        print($"Found object by name: {targetObject.name}");
    }
    else
    {
        print("No TargetObject found.");

    }
    jokerObject = GameObject.FindGameObjectWithTag("Joker");
    if(jokerObject != null)
    {
        print($"Found object by tag: {jokerObject.name}");
    }
    else
    {
        print("No Joker object found.");
    }
    lightObject = GameObject.FindObjectOfType<Light>();
    if(lightObject != null)
    {
        print($"Found object of type Light: {lightObject.name}");
    }
    else
    {
        print("No Light object found.");
    }
   }


   void Update()
   {
    if(Input.GetKeyDown(KeyCode.D))
    {
        print("TargetObject deactivated!");
        targetObject.SetActive(false);
        
    }
   }
}
}