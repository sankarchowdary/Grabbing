using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetection : MonoBehaviour
{
    public GameObject DragObject, TargetObject;
    public Vector3 DragObjectRotation;
    public Vector3 DragObjectpostion;
    public static ObjectDetection Instance;
    public GameObject Restriced;
   
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    public void Update()
    {
       
    }

   
    public void OnTriggerEnter(Collider other)
    {
        Restriced.SetActive(true);
        // DragObject.transform.eulerAngles = DragObjectRotation;
        //  DragObject.transform.position = DragObjectpostion;
        print("Enter");
     //   MainController.Instance.RayCastControllerOff();
    }
    public void OnTriggerExit(Collider other)
    {
        print("Exit");
        Restriced.SetActive(false);
        //  MainController.Instance.RayCastControllerOn();
    }


    public void XRSocetInteracterController()
    {

    }

}
