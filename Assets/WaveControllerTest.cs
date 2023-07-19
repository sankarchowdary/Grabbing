using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class WaveControllerTest : MonoBehaviour
{
   // public TextMeshPro debugText;
    public XRNode node;

    

    // Update is called once per frame
    void Update()
    {

        InputHelpers.IsPressed(InputDevices.GetDeviceAtXRNode(node), InputHelpers.Button.Trigger, out bool triggerValue, 0.5f);
        if (triggerValue)
        {
            //debugText.text = $"{node}-trigger";
            Debug.Log("trigger");
        }

        InputHelpers.IsPressed(InputDevices.GetDeviceAtXRNode(node), InputHelpers.Button.Grip, out bool gripPressed, 0.5f);
        if (gripPressed)
        {
            Debug.Log( "Grip pressed");
        }
        InputHelpers.IsPressed(InputDevices.GetDeviceAtXRNode(node), InputHelpers.Button.PrimaryAxis2DUp, out bool touchpadValue, 0.5f);
        if (touchpadValue)
        {
            Debug.Log("touchpad");
        }

        InputHelpers.IsPressed(InputDevices.GetDeviceAtXRNode(node), InputHelpers.Button.PrimaryButton, out bool primaryButton, 0.5f);
        if (primaryButton)
        {
            Debug.Log("primaryButton");
        }
    }
}