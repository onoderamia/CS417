using UnityEngine;
using UnityEngine.XR;

public class Quit : MonoBehaviour
{
    bool lastPress = false;

    void Update()
    {
        InputDevice rightHand =
            InputDevices.GetDeviceAtXRNode(XRNode.RightHand);

        if (rightHand.TryGetFeatureValue(CommonUsages.secondaryButton, out bool pressed))
        {
            if (pressed && !lastPress)
            {
                Application.Quit();
            }

            lastPress = pressed;
        }
    }
}
