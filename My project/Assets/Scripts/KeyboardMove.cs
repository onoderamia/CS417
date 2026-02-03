using UnityEngine;

public class KeyboardMove : MonoBehaviour
{
    public float speed = 2f;
    public float mouseSensitivity = 100f;

    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // --- Movement (WASD) ---
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h, 0, v);
        transform.Translate(move * speed * Time.deltaTime, Space.Self);

        // --- Mouse look ---
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        // Look up/down
        Camera.main.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Look left/right
        transform.Rotate(Vector3.up * mouseX);
    }
}
