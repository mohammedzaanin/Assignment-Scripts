using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player = new Player("Sonic",90);
        Enemy enemy = new Enemy("Doctor.Eggman",100);
        Debug.Log("Player details: ");
        Debug.Log("Player Name: " + player.Name);
        Debug.Log("Player Health: " + player.Health);
        Debug.Log("--------------------------------------");
        Debug.Log("Enemy details: ");
        Debug.Log("Enemy Name: " + enemy.Name);
        Debug.Log("Enemy Health: " + enemy.Health);
        Debug.Log("--------------------------------------");
        player.Heal(10);
        Debug.Log("Heal Player:");
        Debug.Log("The Player Health Now: " + player.Health);
        enemy.Attack(player,20);
        Debug.Log("--------------------------------------");
        Debug.Log("The Player Take Damage:");
        Debug.Log("The Player Health Now: " + player.Health);
    }

   
}
