using UnityEngine;
using UnityEngine.XR;

public class QuestInputDebug : MonoBehaviour
{
    InputDevice left, right;

    void Update()
    {
        if (!left.isValid) left = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        if (!right.isValid) right = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
    }

    void OnGUI()
    {
        GUILayout.Label($"Left valid: {left.isValid} | Right valid: {right.isValid}");

        if (right.isValid)
        {
            right.TryGetFeatureValue(CommonUsages.primaryButton, out bool a);
            right.TryGetFeatureValue(CommonUsages.secondaryButton, out bool b);
            right.TryGetFeatureValue(CommonUsages.triggerButton, out bool trig);
            right.TryGetFeatureValue(CommonUsages.gripButton, out bool grip);
            right.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out bool stick);

            GUILayout.Label($"RIGHT  A(primary): {a}  B(secondary): {b}");
            GUILayout.Label($"RIGHT  Trigger: {trig}  Grip: {grip}  StickClick: {stick}");
        }

        if (left.isValid)
        {
            left.TryGetFeatureValue(CommonUsages.primaryButton, out bool x);
            left.TryGetFeatureValue(CommonUsages.secondaryButton, out bool y);

            GUILayout.Label($"LEFT   X(primary): {x}  Y(secondary): {y}");
        }
    }
}
