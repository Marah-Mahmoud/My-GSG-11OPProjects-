using UnityEngine;
using System;
namespace Assignment35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        void Start()
        {
            Action logMessage = () => Debug.Log("Hello from Action delegate!");
            logMessage();

            Func<int, int> square = num => num * num;
            Debug.Log($"Square: {square(5)}");

            Predicate<int> isEven = num => num % 2 == 0;
            Debug.Log($"Is 4 even? {isEven(4)}");
        }
    }
}