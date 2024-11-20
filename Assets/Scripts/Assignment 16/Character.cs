using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
public class Character 
{
    public string name;
    private int health;
    public int Health
    {
        get{
            return health;
        }
        set{
            if(value > 100){
                health = 100;
            }
            else if(value < 0){
                health = 0;
            }
            else{
                health =value;
            }
        }
    }
    protected Position position;

    public Character(string Charactername, int characterhealth, Position characterposition)
    {
        this.name = Charactername;
        this.health = characterhealth;
        this.position = characterposition;
    }

    public Character() : this("No name", 100, new Position(0,0,0))
    {

    }
    public virtual void DisplayInfo()
    {
        Debug.Log("Character information:");
        Debug.Log("Character Name: " + name);
        Debug.Log("Character Health: " + health);
        position.printPosition();
    }
}
}
