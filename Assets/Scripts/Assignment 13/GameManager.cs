using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player T1 = new Player();
        Player BLG = new Player();
        T1.InitializePlayer("Faker",100);
        BLG.InitializePlayer("Elk",80);
        T1.Heal(10);
        T1.Heal(true);
        BLG.Heal(10);
        BLG.Heal(true);
        Player.ShowPlayerCount();
    }

}
