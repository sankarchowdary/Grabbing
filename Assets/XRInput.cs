using System;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class XRInput : MonoBehaviour
{
    

    private enum ControllerSide
    {
        Left_Controller,
        Right_Controller,
    }

    public bool isRight;

    [SerializeField]
    private ControllerSide m_controller;

    private InputDeviceCharacteristics m_characteristics;

    [SerializeField]
    private bool m_debugMode = true;

    private InputDevice targetDevice;

    private void Awake()
    {
        
    }
    private void Start()
    {
        if (m_controller == ControllerSide.Left_Controller)
        {
            m_characteristics = InputDeviceCharacteristics.Left;
            isRight = false;
        }
        else
        {
            m_characteristics = InputDeviceCharacteristics.Right;
            isRight = true;
        }
    }

    private void Update()
    {
        List<InputDevice> m_device = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(m_characteristics, m_device);

        if (m_device.Count == 1)
        {
            targetDevice = m_device[0];
            CheckController();
        }
        else
        {
            //Debug.Log("Controller Not Found");
        }
    }

    private void CheckController()
    {

        targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonDown);
        if (primaryButtonDown)
        {
            print("primarybutton");
            if (isRight) {


            }
            else
            {

            }
                

        }
        else
        {
            if (isRight) { }



            else { }
               
        }


        targetDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondaryButton);
        if (secondaryButton)
        {
            print("secondarybutton");
            if (isRight) { }



            else { }
               

        }
        else
        {
            if (isRight) { }



            else { }
               
        }


        targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float trigger);
        if (trigger > 0.01f)
        {
            if (isRight) { }




            else { }
              

        }
        else
        {
            if (isRight) { }



            else { }

        }


        targetDevice.TryGetFeatureValue(CommonUsages.grip, out float grip);
        if (grip > 0.01f)
        {
            if (isRight) { }



            else { }
                

        }
        else
        {
            if (isRight) {  }


            else { }
               
        }

    }



}