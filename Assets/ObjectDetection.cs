using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetection : MonoBehaviour
{
    public GameObject DragObject, TargetObject;
    public GameObject[] Highlightparts;
    public bool stopposition = true;
    public static ObjectDetection Instance;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    public void Update()
    {
        //if (UnityEngine.XR.GetUp(OVRInput.Button.PrimaryThumbstickRight))
        //{
        //    gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
        //}

        //if (OVRInput.GetUp(OVRInput.Button.PrimaryThumbstickLeft))
        //{
        //    gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);
        //}

    }
    public int i;
    public void test()
    {
        i++;
        print(i);
        DragObject.SetActive(false);
        TargetObject.GetComponent<MeshRenderer>().enabled = true;
           

        if ( i == 1){
            Highlightparts[0].SetActive(false);

        }
        if (i == 2)
        {
            print("two");
            Highlightparts[1].SetActive(false);

        }
        if (i == 3)
        {
            Highlightparts[2].SetActive(false);

        }
        if (i == 4)
        {
            Highlightparts[3].SetActive(false);


        }

    }

   
    public void OnTriggerEnter(Collider other)
    {
        
     if(other.tag == "G1_geo" || other.tag == "G2_geo"|| other.tag == "G3_geo"|| other.tag == "G4_geo")
     {

               
      //if (DragObject.transform.rotation.eulerAngles.x == TargetObject.transform.rotation.x && DragObject.transform.rotation.eulerAngles.z == TargetObject.transform.rotation.z)
      //{
             //   test();
               
     // }



     }
     
    }
    public void OnClick()
    {
      
        DragObject.transform.rotation = TargetObject.transform.rotation;
        DragObject.transform.localPosition = new Vector3(0,0,-2);
        
      
    }


}
