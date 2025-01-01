using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {
        void Start()
        {
            List<Creature> creatures = new List<Creature> { new Kangaroo(), new Duck() };
            List<IRunnable> runnables = new List<IRunnable>();
            List<IJumpable> jumpables = new List<IJumpable>();
            List<ISwimmable> swimmables = new List<ISwimmable>();

            foreach (Creature creature in creatures)
            {
                if (creature is IRunnable runnable)
                {
                    runnables.Add(runnable);
                }

                if (creature is IJumpable jumpable)
                {
                    jumpables.Add(jumpable);
                }

                if (creature is ISwimmable swimmable)
                {
                    swimmables.Add(swimmable);
                }
            }


            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }

            foreach (IRunnable runnable in runnables)
            {
                runnable.Run();
            }

            foreach (IJumpable jumpable in jumpables)
            {
                jumpable.Jump();
            }

            foreach (ISwimmable swimmable in swimmables)
            {
                swimmable.Swim();
            }
        }
    }
}
