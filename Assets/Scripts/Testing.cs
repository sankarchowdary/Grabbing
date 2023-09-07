using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class Testing : MonoBehaviour
{

  public  UnityEvent m_MyEvent;
    public Transform grabobject;
    public float ypostion;
    void Start()
    {
        if (m_MyEvent == null)
            m_MyEvent = new UnityEvent();

        m_MyEvent.AddListener(Ping);
    }

    void Update()
    {
        ypostion = grabobject.transform.localPosition.z;
        print(ypostion);
        if (Input.anyKeyDown && m_MyEvent != null)
        {
            m_MyEvent.Invoke();
        }
    }
    public void OnTriggerStay(Collider other)
    {
        print("trigger");
        if (ypostion >= 3 && ypostion <= 5)
        {
            print("done");

        }
    }

    void Ping()
    {
        Debug.Log("Ping");
    }
}