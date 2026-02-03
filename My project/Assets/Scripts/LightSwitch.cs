using UnityEngine;
using UnityEngine.XR;

public class LightSwitch : MonoBehaviour
{
    Light pointLight;
    bool isWhite = true;
    bool lastPress = false;

    void Start()
    {
        pointLight = GetComponent<Light>();
    }

    void Update()
    {
        InputDevice leftHand =
            InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);

        if (leftHand.TryGetFeatureValue(CommonUsages.primaryButton, out bool pressed))
        {
            if (pressed && !lastPress)
            {
                ToggleLight();
            }

            lastPress = pressed;
        }
    }

    void ToggleLight()
    {
        if (isWhite)
        {
            pointLight.color = Color.red;
            isWhite = false;
        }
        else
        {
            pointLight.color = Color.white;
            isWhite = true;
        }
    }
}
