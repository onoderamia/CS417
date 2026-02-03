using UnityEngine;

public class OrbitMoon : MonoBehaviour
{
    public float rotationSpeed = 60f; 

    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
