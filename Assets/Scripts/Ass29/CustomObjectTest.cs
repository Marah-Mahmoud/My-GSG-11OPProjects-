using UnityEngine;
namespace Assignment29
{

    public class CustomObjectTest : MonoBehaviour
    {
        void Start()
        {
            CustomObject obj1 = new CustomObject(1, "Example");
            print(obj1);

            CustomObject obj2 = new CustomObject(2, "Another");
            print(obj1 == obj2);
            print(obj1 != obj2);
        }
    }
}
