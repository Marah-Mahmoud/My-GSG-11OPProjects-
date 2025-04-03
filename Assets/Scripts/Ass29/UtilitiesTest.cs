using UnityEngine;
namespace Assignment29
{
    public class UtilitiesTest : MonoBehaviour
    {
        void Start()
        {
            // Test Add method
            int sum = Utilities.Add(1, 2, 3, 4, 5);
            Debug.Log($"Sum: {sum}");

            // Test RepeatString method
            string repeated = "Hello".RepeatString(3);
            Debug.Log(repeated);
        }
    }
}