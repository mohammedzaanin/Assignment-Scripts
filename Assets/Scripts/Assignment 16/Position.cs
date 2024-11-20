using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
public struct Position
{
    public float X;
    public float Y;
    public float Z;

    public Position(float x_value, float y_value, float z_value)
    {
        this.X = x_value;
        this.Y = y_value;
        this.Z = z_value;
    }
    public void printPosition()
    {
        Debug.Log("the Position values for (X, Y, Z) for Character = "+"(" + X +", " + Y +", " + Z +")");
    }
}
}
