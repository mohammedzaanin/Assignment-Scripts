using System.Collections;
using System.Collections.Generic;
using Assignment26;
using UnityEngine;
namespace Assignment26
{
public class CreatureManager : MonoBehaviour
{
    List<Creature> creature;
    Kangaroo kangaroo_01 = new Kangaroo();
    Duck duck_01 = new Duck();
    List<IRunnable> runnables = new List<IRunnable>();
    List<IJumpable> jumpables = new List<IJumpable>();
    List<ISwimmable> swimmables = new List<ISwimmable>();
    void Start()
    {
        creature = new List<Creature>(){kangaroo_01,duck_01};
        runnables.Add(kangaroo_01);
        jumpables.Add(kangaroo_01);
        runnables.Add(duck_01);
        swimmables.Add(duck_01);
        foreach (Creature creatureitem in creature)
        {
            creatureitem.Speak();
        }
        foreach (IRunnable runnableitem in runnables)
        {
            runnableitem.Run();
        }
        foreach (IJumpable jumpableitem in jumpables)
        {
            jumpableitem.Jump();
        }
        foreach (ISwimmable swimmableitem in swimmables)
        {
            swimmableitem.Swim();
        }
    }
}
}