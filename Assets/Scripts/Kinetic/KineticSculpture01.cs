using UnityEngine;

public class KineticSculpture01 : MonoBehaviour
{
    public int numberOfSpheres = 10; // Number of orbiting spheres
    public float orbitRadius = 5f; // Radius of the orbit
    public float orbitSpeed = 1f; // Speed of the orbit
    public float pulsationSpeed = 2f; // Speed of size pulsation
    public GameObject spherePrefab; // Prefab for spheres
    public Light centralLight; // Central light for dynamic lighting

    private GameObject[] spheres;

    void Start()
    {
        // Create spheres and place them in orbit
        spheres = new GameObject[numberOfSpheres];
        for (int i = 0; i < numberOfSpheres; i++)
        {
            spheres[i] = Instantiate(spherePrefab, transform);
            float angle = i * Mathf.PI * 2f / numberOfSpheres;
            Vector3 position = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * orbitRadius;
            spheres[i].transform.localPosition = position;
        }
    }

    void Update()
    {
        // Rotate spheres around the central object
        for (int i = 0; i < numberOfSpheres; i++)
        {
            float angle = i * Mathf.PI * 2f / numberOfSpheres + Time.time * orbitSpeed;
            Vector3 position = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * orbitRadius;
            spheres[i].transform.localPosition = position;

            // Pulsate size
            float scale = 1 + Mathf.Sin(Time.time * pulsationSpeed) * 0.5f;
            spheres[i].transform.localScale = Vector3.one * scale;
        }

        // Change light intensity dynamically
        centralLight.intensity = 2 + Mathf.Sin(Time.time * pulsationSpeed) * 1.5f;
    }
}