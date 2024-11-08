using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public Player(string Playername , int playerhealth){
        Name = Playername;
        Health = playerhealth;
    }   
    public void Heal(int amount){
        if(Health > 100){
            Health = 100;
        }
        else if(Health < 0){
            Health = 0;
        }
        else{
            Health += amount;
        }
    }   
}
