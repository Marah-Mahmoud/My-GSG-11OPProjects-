using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public interface ICanFight
    {
        void Attack();
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

    public class Cat : Animal, ICanFight
    {
        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }

        public new void Move()
        {
            Debug.Log("Cat runs quickly.");
        }

        public void Attack()
        {
            Debug.Log("Cat attacks with claws!");
        }
    }

    public class Warrior : ICanFight
    {
        public void Attack()
        {
            Debug.Log("Warrior attacks with a sword!");
        }
    }

    public class TypeManagementScript : MonoBehaviour
    {
        void Start()
        {
            // Upcasting and downcasting
            Cat myCat = new Cat();
            Animal myAnimal = myCat; // Upcasting
            myAnimal.MakeSound();
            myAnimal.Move();

            Cat downcastedCat = myAnimal as Cat; // Downcasting
            if (downcastedCat != null)
            {
                downcastedCat.MakeSound();
                downcastedCat.Move();
            }

            // Type checking and interface testing
            List<ICanFight> fighters = new List<ICanFight> { new Cat(), new Warrior() };
            foreach (var fighter in fighters)
            {
                fighter.Attack();
                if (fighter is Cat)
                    Debug.Log("The object is a Cat.");
                else if (fighter is Warrior)
                    Debug.Log("The object is a Warrior.");
            }
        }
    }
}
