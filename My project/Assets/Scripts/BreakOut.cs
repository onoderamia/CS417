using UnityEngine;

public class BreakOutSimple : MonoBehaviour
{
    public Transform SpawnPoint;
    public Transform OutsidePoint;
    public Transform CameraOffset; 


    private bool isOutside = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0) || Input.GetKeyDown(KeyCode.A))
        {
            isOutside = !isOutside;

            if (isOutside) 
            {
                transform.position = OutsidePoint.position;
                CameraOffset.localRotation = Quaternion.Euler(40f, 0f, 0f);
            }
            else
            {
                transform.position = SpawnPoint.position;
                CameraOffset.localRotation = Quaternion.Euler(0f, 0f, 0f);
            }
        }
    }
}

