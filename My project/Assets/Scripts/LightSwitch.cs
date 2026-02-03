using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    Light pointLight;
    bool isWhite = true;

    void Start()
    {
        pointLight = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton3) || Input.GetKeyDown(KeyCode.Tab))
        {
            if(isWhite) 
            {
                pointLight.color = Color.skyBlue;
                isWhite = false;
            }
            else 
            {
                pointLight.color = Color.white;
                isWhite = true;
            }
        }
    }
}
