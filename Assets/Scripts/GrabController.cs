using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using UnityEngine.UI;
public class GrabController : MonoBehaviour
{
    public GameObject GrabObject;
    public GameObject TargetObject;
    public GameObject HighLightObject;
    // public GameObject PreviousObject; 
    public GameObject NextObject;
    public float XaxisPosition;
    public float YaxisPosition;
    public float ZaxisPosition;
    public float YRotation;
    public Vector3 GrabObjectPostion;
    public Quaternion GrabObjectRotation;
    public bool OpenBool, CloseBool,CordinatesBool;
    public static GrabController Instance;



    public void Start()
    {
        Instance = this;
    }
    // Start is called before the first frame update

    public void OnTriggerStay(Collider other)
    {
        if (OpenBool)
        {
           
            GrabObject.SetActive(false);
            TargetObject.GetComponent<MeshRenderer>().enabled = true;
            TargetObject.GetComponent<BoxCollider>().enabled = false;
            NextObject.SetActive(true);
            HighLightObject.SetActive(false);
            OpenBool = false;
            CordinatesBool = false;
        }
     // && ZaxisPosition >= -17 && ZaxisPosition <= -16 && XaxisPosition >= -16 && XaxisPosition <= -17
        if (other.tag == ("G1_geo"))
        {
            if (YRotation > 175 && YRotation < 180 )
            {
                OpenBool = true;
                MainController.Instance.ButtonAcessOn(0);
            }
        }
        else if (other.name == ("G2_geo"))
        {
            if (YRotation > 175 && YRotation < 180)
            {
                OpenBool = true;
                MainController.Instance.ButtonAcessOn(1);
            }
        }
        else if (other.name == ("G3_geo"))
        {
            if (YRotation > 175 && YRotation < 180)
            {
                OpenBool = true;
                MainController.Instance.ButtonAcessOn(2);
            }
        }
        else if (other.name == ("G4_geo"))
        {
            if (YRotation > 175 && YRotation < 180)
            {
                OpenBool = true;
                MainController.Instance.ButtonAcessOn(3);
            }
        }
        else if (other.name == ("G5_geo"))
        {
            if (YRotation > 175 && YRotation < 180)
            {
                OpenBool = true;
                MainController.Instance.ButtonAcessOn(4);
            }

        }
    }
   
   
    // Update is called once per frame
    void Update()
    {
       
            YRotation = GrabObject.transform.eulerAngles.y;
          //  print(YRotation);
          
     
       
       
    }
}
