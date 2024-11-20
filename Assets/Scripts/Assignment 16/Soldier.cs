using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18{
public class Soldier : Character
{
    public Soldier(string Soldiername, int Soldierhealth, Position Soldierposition): base(Soldiername, Soldierhealth, Soldierposition)
    {

    }
    public Soldier(): base()
    {
        
    }

    public override void DisplayInfo()
    {
        Debug.Log("Soldier");
        base.DisplayInfo();

    }
}
}