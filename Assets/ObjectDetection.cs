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
    

   
     Shader shader1;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        print("test");
        
       /// shader1 = Shader.Find("Universal Render Pipeline/Lit/Transparent/Diffuse");
     //   Mat1.material.shader = shader1;
       
    }

    // Update is called once per frame
    public void Update()
    {
       
    }
  
     void OnTriggerEnter(Collider other)
    {
      
            Restriced.SetActive(true);
        
       
    }
    public void OnTriggerExit(Collider other)
    {
     
        Restriced.SetActive(false);
        //  MainController.Instance.RayCastControllerOn();
    }


    public void XRSocetInteracterController()
    {

    }

}
