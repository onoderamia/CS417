using UnityEngine;
using UnityEngine.XR;

public class BreakOutSimple : MonoBehaviour
{
    public Transform SpawnPoint;
    public Transform OutsidePoint;
    public Transform CameraOffset;

    private bool isOutside = false;
    private bool lastPress = false;

    void Update()
    {
        InputDevice leftHand = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);

        if (leftHand.TryGetFeatureValue(CommonUsages.secondaryButton, out bool pressed))
        {
            if (pressed && !lastPress)
            {
                Toggle();
            }

            lastPress = pressed;
        }
    }

    void Toggle()
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
