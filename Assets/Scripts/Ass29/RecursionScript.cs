using UnityEngine;
namespace Assignment29
{
    public class RecursionScript : MonoBehaviour
    {
        void Start()
        {
            int n = 10;
            Debug.Log($"FibonacciRecursive({n}): {FibonacciRecursive(n)}");
            Debug.Log($"FibonacciIterative({n}): {FibonacciIterative(n)}");

            n = 30;
            Debug.Log($"FibonacciRecursive({n}): {FibonacciRecursive(n)}");
            Debug.Log($"FibonacciIterative({n}): {FibonacciIterative(n)}");
        }

        int FibonacciRecursive(int n)
        {
            if (n <= 1) return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        int FibonacciIterative(int n)
        {
            if (n <= 1) return n;
            int a = 0, b = 1, result = 0;
            for (int i = 2; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }
            return result;
        }
    }
}
