using UnityEngine;
using System.Collections.Generic;
namespace Assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {
        void Start()
        {
            List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };
            numbers.Sort((x, y) => y.CompareTo(x));

            Debug.Log(string.Join(", ", numbers));
        }
        //findall
        // void FilterEvenNumbers()
        // {
        //     List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
        //     List<int> filteredNumbers = numbers2.FindAll(num => num % 2 == 0);

        //     Debug.Log(string.Join(", ", filteredNumbers));
        // }

    }
}