using UnityEngine;
namespace Assignment29
{
    public class UnitySpecificScript : MonoBehaviour
    {
        void OnEnable()
        {
            print("GameObject Enabled");
        }

        void OnDisable()
        {
            print("GameObject Disabled");
        }

        void Start()
        {
            print("Game started!");

            GameObject targetObject = GameObject.Find("TargetObject");
            if (targetObject != null)
                print($"Found object by name: {targetObject.name}");
            else
                print("No TargetObject found.");

            GameObject joker = GameObject.FindGameObjectWithTag("Joker");
            if (joker != null)
                print($"Found object by tag: {joker.name}");
            else
                print("No Joker object found.");

            Light light = GameObject.FindObjectOfType<Light>();
            if (light != null)
                print($"Found object of type Light: {light.name}");
            else
                print("No Light object found.");
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                GameObject targetObject = GameObject.Find("TargetObject");
                if (targetObject != null)
                {
                    targetObject.SetActive(false);
                    print("TargetObject deactivated!");
                }
            }
        }
    }
}
