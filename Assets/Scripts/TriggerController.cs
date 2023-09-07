using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;


public class TriggerController : MonoBehaviour
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
    [Serializable] public class ColliderEvent : UnityEvent<Collider> { }
   // [SerializeField]
   // [Tooltip("If set, this collision will only fire if the other gameobject has this tag.")]
    string m_RequiredTag = string.Empty;
    public bool changed;

    [SerializeField]
    [Tooltip("Events to fire when a matcing object collides with this one.")]
    ColliderEvent m_OnEnter = new ColliderEvent();

    [SerializeField]
    [Tooltip("Events to fire when a matching object stops colliding with this one.")]
    ColliderEvent m_OnExit = new ColliderEvent();
    public bool RightHandBool, LeftHandBool;
    /// <summary>
    /// If set, this collision will only fire if the other gameobject has this tag.
    /// </summary>
    public string requiredTag => m_RequiredTag;
   

    /// <summary>
    /// Events to fire when a matching object collides with this one.
    /// </summary>
    public ColliderEvent onEnter => m_OnEnter;

    /// <summary>
    /// Events to fire when a matching object stops colliding with this one.
    /// </summary>
    public ColliderEvent onExit => m_OnExit;


    public void OnTriggerStay(Collider other)
    {
       
        if (other.gameObject.CompareTag("LeftHand"))
        {
            LeftHandBool = true;
           
        }
        if (other.gameObject.CompareTag("RightHand"))
        {
            RightHandBool = true;

        }
        if (RightHandBool == LeftHandBool)
        {
            if (CanInvoke(other.gameObject))
                m_OnEnter?.Invoke(other);
        }
        else
        {
            if (CanInvoke(other.gameObject))
                m_OnExit?.Invoke(other);
        }
    }
        public void OnTriggerExit(Collider other)
        {
        
        RightHandBool = false;
        LeftHandBool = false;
            print("Exit");
           if (CanInvoke(other.gameObject))
                m_OnExit?.Invoke(other);
        
         }

    bool CanInvoke(GameObject otherGameObject)
    {
        return string.IsNullOrEmpty(m_RequiredTag ) || otherGameObject.CompareTag(m_RequiredTag);
    }

    public void Update()
    {
        GrabObjectPostion = GrabObject.transform.localPosition;
        GrabObjectPostion.x.ToString();
        XaxisPosition = GrabObjectPostion.x;
        print(XaxisPosition);

        YRotation = GrabObject.transform.eulerAngles.y;

        print(YRotation);

        if (YRotation > 175 && YRotation < 180)
        {
            print("Rotation");
        }
    }
    // Update is called once per frame

}
