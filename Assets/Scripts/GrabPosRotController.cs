using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
public class GrabPosRotController : MonoBehaviour
{
    public float XaxisPosition;
    public float YaxisPosition;
    public float ZaxisPosition;
    public float BalanceValue;
    public float YRotation;
    public float BalanceRoation;
    public GameObject GrabObject;
    public Vector3 GrabObjectPostion;
    public Quaternion GrabObjectRotation;
    public bool GrabActivation,EventActivation;
    [Serializable] public class ColliderEvent : UnityEvent<Collider> { }

     [SerializeField]
     [Tooltip("If set, this collision will only fire if the other gameobject has this tag.")]
    string m_RequiredTag = string.Empty;
    public bool changed;

    [SerializeField]
    [Tooltip("Events to fire when a matcing object collides with this one.")]
     ColliderEvent m_OnEnter = new ColliderEvent();

    [SerializeField]
    [Tooltip("Events to fire when a matching object stops colliding with this one.")]
    ColliderEvent m_OnExit = new ColliderEvent();
    [SerializeField]
    [Tooltip("Events to fire when a matching object stops colliding with this one.")]
   
    public string requiredTag => m_RequiredTag;

    public ColliderEvent onEnter => m_OnEnter;
   

    public ColliderEvent onExit => m_OnExit;
    
    void Start()
    {
        //  GrabActivation = true;
        
      


    }

  
    public void OnTriggerEnter(Collider other)
    {


        if (CanInvoke(other.gameObject))
            m_OnEnter?.Invoke(other);
        if (YRotation > 175 && YRotation < 180)
        {
            print("DONE");
           // m_OnEnter?.Invoke(other);
        }
       
       

    }
   

    public void OnTriggerExit(Collider other)
    {
        if (CanInvoke(other.gameObject))
            m_OnExit?.Invoke(other);
        GrabActivation = false;


    }
    bool CanInvoke(GameObject otherGameObject)
    {
        return string.IsNullOrEmpty(m_RequiredTag) || otherGameObject.CompareTag(m_RequiredTag);
    }



    // Start is called before the first frame update

    // Update is called once per frame
    public void Update()
    {
        //GrabObjectPostion = GrabObject.transform.localPosition;
        //GrabObjectPostion.x.ToString();
        //XaxisPosition = GrabObjectPostion.x;
        //print(XaxisPosition);

        YRotation = GrabObject.transform.eulerAngles.y;

        print(YRotation);


        if (YRotation > 175 && YRotation < 180)
        {
            GrabActivation = true;
            print("sucess");
        }

        else
        {
           
            GrabActivation = false;
        }
    }

}
