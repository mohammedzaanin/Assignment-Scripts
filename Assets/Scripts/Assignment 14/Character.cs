using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
   private string name;
   private int health;
   public Character(string charactername , int characterhealth){
    name = charactername;
    health = characterhealth;
   }
   public string Name{
    get{
        return name;
    }
    set{
        name = value;
    }
   }
   public int Health{
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
            health = value;
        }
        
    }
   }
}
