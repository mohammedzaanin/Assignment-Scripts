using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
public class TestAbstractClass : MonoBehaviour
{
    DerivedClassExample derivedClasstest;
    void Start()
    {
        derivedClasstest = GetComponent<DerivedClassExample>();
        derivedClasstest.PerformAction();
        derivedClasstest.PrintInfo();

    }

    void Update()
    {
        
    }
}
}