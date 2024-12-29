using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
public class TypeManagementScript : MonoBehaviour
{
    
    void Start()
    {
        Animal animal_cat = new Cat();
        animal_cat.MakeSound();
        animal_cat.Move();
        Cat cute_cat = animal_cat as Cat;
        cute_cat.MakeSound();
        cute_cat.Move();
        Warrior brave_warrior = new Warrior();
        List<ICanFight> fighters = new List<ICanFight>{cute_cat, brave_warrior};
        foreach(ICanFight fighter in fighters)
        {
            fighter.Attack();
            if (fighter is Cat)
            {
                Debug.Log("The object is a Cat.");
            }
            else if (fighter is Warrior)
            {
                Debug.Log("The object is a Warrior.");
            }
        }
    }

}
public class Animal
{
    public virtual void MakeSound()
    {
        Debug.Log("Animal sound");
    }
    public void Move()
    {
        Debug.Log("Animal moves.");
    }
}
public class Cat: Animal,ICanFight
{
        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }
        public void Move()
        {
            Debug.Log("Cat runs quickly.");
        }
        public void Attack()
        {
            Debug.Log("Cat attacks with claws!");
        }
}
public interface ICanFight
{
    public void Attack();
}
public class Warrior: ICanFight
{
    public void Attack()
    {
        Debug.Log("Warrior attacks with a sword!");
    }
}
}