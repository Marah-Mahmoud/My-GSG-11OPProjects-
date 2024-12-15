using UnityEngine;
public class KineticSculpture : MonoBehaviour
{
    public int numberOfSpheres = 10; // Number of orbiting spheres
    public float orbitRadius = 5f; // Radius of the orbit
    public float orbitSpeed = 1f; // Speed of the orbit
    public float pulsationSpeed = 2f; // Speed of size pulsation
    public float colorChangeSpeed = 2f; // Speed of color change
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

            // Change color
            Renderer renderer = spheres[i].GetComponent<Renderer>();
            float r = Mathf.Abs(Mathf.Sin(Time.time * colorChangeSpeed + i));
            float g = Mathf.Abs(Mathf.Sin(Time.time * colorChangeSpeed + i + Mathf.PI / 2));
            float b = Mathf.Abs(Mathf.Sin(Time.time * colorChangeSpeed + i + Mathf.PI));
            renderer.material.color = new Color(r, g, b);
        }

        // Change light intensity and color dynamically
        centralLight.intensity = 2 + Mathf.Sin(Time.time * pulsationSpeed) * 1.5f;
        centralLight.color = new Color(Mathf.Abs(Mathf.Sin(Time.time)), Mathf.Abs(Mathf.Cos(Time.time)), Mathf.Abs(Mathf.Sin(Time.time * 0.5f)));
    }
}
