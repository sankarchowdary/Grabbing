//using UnityEngine;
//using UnityEngine.Events;
//using System.Collections;

//public class Testing : MonoBehaviour
//{

  
//    public Transform grabobject;
//    public float xposition;
//    public float yposition;
//    public float zposition;
//    public bool xaxisbool;
//    public bool yaxisbool;
//    public bool zaxisbool;
//    public bool yrot;
//    public float YRotation;

//    void Start()
//    {
       
//    }

//    void Update()
//    {
//        xposition = grabobject.transform.position.x;
//        yposition = grabobject.transform.position.y;
//        zposition = grabobject.transform.position.z;
//        print(xposition);
//        print(zposition);
//        print(yposition);
//        YRotation = grabobject.transform.eulerAngles.y;
//        print(YRotation);
        
//    }
//    public void OnTriggerStay(Collider other)
//    {
//        print("trigger");
//        if (xposition >= 7f && xposition <= 8f  )
//        {
//            print("xaxis");
//            xaxisbool = true;
//        }
//        else if ( yposition >= 1f && yposition <= 2f )
//        {
//            print("yaxis");
//            yaxisbool = true;
//        }
//       else if(zposition <= -5 && zposition >= -6f)
//        {
//            print("zaxis");
//            zaxisbool = true;
//        }
//       else if (YRotation > 175 && YRotation < 180) {

//            print("yrot");
//            yrot = true;
//        }
//       else if (xaxisbool && yaxisbool && zaxisbool && yrot)
//        {
//            print("shankar");
//        }
        
//    }

//    void Ping()
//    {
//        Debug.Log("Ping");
//    }
//}