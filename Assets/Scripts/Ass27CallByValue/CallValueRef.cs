using UnityEngine;

namespace Assignment27
{
    public class CallValueRef : MonoBehaviour
    {
        void Start()
        {
            int number1 = 10;
            int number2 = 20;
            int number3;

            CallByValue(number1);
            Debug.Log("number1 after CallByValue = " + number1);

            CallByRef(ref number2);
            Debug.Log("number2 after CallByRef = " + number2);

            CallByOut(out number3);
            Debug.Log("number3 after CallByOut = " + number3);
        }

        void CallByValue(int num)
        {
            num += 10;
        }

        void CallByRef(ref int num01)
        {
            num01 += 10;
        }

        void CallByOut(out int num02)
        {
            num02 = 50;
        }

    }
}
