using System.Collections;
using System.Collections.Generic;
using Assignment18;
using UnityEngine;

namespace Assignment18{
public class CharacterTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Officer officer1 = new Officer("Captain Price", 100, new Position(5,15,5));
        Soldier soldier1 = new Soldier();
        Character[] characters = new Character[2];
        characters[0] = officer1;
        characters[1] = soldier1;
        for(int i = 0; i<characters.Length;i++)
        {
            characters[i].DisplayInfo();
        }
        Debug.Log("--------------------------------------");
        Debug.Log("the Soldier Health " + soldier1.Health);
        officer1.Attack(50,soldier1);
        Debug.Log("the Officer Attack Soldire");
        Debug.Log("the Soldier Health now " + soldier1.Health);
    }

}
}