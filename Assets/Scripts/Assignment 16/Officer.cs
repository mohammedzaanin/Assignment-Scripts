using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18{
public class Officer : Character
{
    public Officer(string Officername, int Officerhealth, Position Officerposition): base(Officername, Officerhealth, Officerposition)
    {

    }
    public Officer() : base()
    {
        
    }

    public override void DisplayInfo()
    {
        Debug.Log("Officer");
        base.DisplayInfo();

    }
}
}