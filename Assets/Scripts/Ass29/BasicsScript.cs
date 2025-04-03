using UnityEngine;
namespace Assignment29
{
    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
            var number = 3;
            var message = "My name is Marah!";
            var isActive = true;

            string numType = (number % 2 == 0) ? "even" : "odd";

            Debug.Log($"The number {number} is {numType}.");
            Debug.Log($"The message is {message}.");
            Debug.Log($"The boolen is {isActive}.");

            Debug.Log($"Current Date: {System.DateTime.Now.ToShortDateString()}");
            Debug.Log($"Current Time: {System.DateTime.Now.ToLongTimeString()}");
            Debug.Log($"Current Day: {System.DateTime.Now.DayOfWeek}");
        }
    }
}
