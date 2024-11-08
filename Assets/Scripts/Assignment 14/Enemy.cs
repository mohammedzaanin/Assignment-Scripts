using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string enemyname , int enemyhealth){
        Name = enemyname;
        Health = enemyhealth;
    }

    public void Attack(Character defender ,int amount){
        if(defender.Health < 0){
            defender.Health = 0;
        }
        else{
            defender.Health -= amount;
        }
    }
}
