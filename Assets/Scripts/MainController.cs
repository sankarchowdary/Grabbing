using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour
{
    public GameObject[] DragObject;
    public GameObject[] HighLightParts;
    public Vector3 DragObjectRotation;
    public Vector3 DragObjectpostion;
    public GameObject[] button;
    public int i,ButtonCount;
    public GameObject LeftRayCast,RightRayCast;
    public static MainController Instance;
    public bool ButtonAcess;
    public GameObject[] TargetObjects;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        ButtonAcess = true;
    }



    public void ButtonController(int id)
    {
        if (ButtonAcess)
        {
            ButtonCount++;
           // LeftRayCast.SetActive(false);
           // RightRayCast.SetActive(false);
            
            print(ButtonCount);
            for (i = 0; i < 5; i++)
            {
                button[i].GetComponent<Button>().interactable = false;
            }
            if (id == 0)
            {
                button[ButtonCount].GetComponent<Button>().interactable = true;
                DragObject[0].SetActive(true);
                HighLightParts[0].SetActive(true);
               
            }
            else if (id == 1)
            {
                button[ButtonCount].GetComponent<Button>().interactable = true;
                DragObject[1].SetActive(true);
                HighLightParts[1].SetActive(true);
            }
            else if (id == 2)
            {
                button[ButtonCount].GetComponent<Button>().interactable = true;
                DragObject[2].SetActive(true);
                HighLightParts[2].SetActive(true);
            }
            else if (id == 3)
            {
                button[ButtonCount].GetComponent<Button>().interactable = true;
                DragObject[3].SetActive(true);
                HighLightParts[3].SetActive(true);
            }
            else if (id == 4)
            {
                // button[ButtonCount].GetComponent<Button>().interactable = true;
                DragObject[4].SetActive(true);
                HighLightParts[4].SetActive(true);
            }
            ButtonAcess = false;
        }
    }
    // Update is called once per frame
   
    public void RayCastControllerOn()
    {
        LeftRayCast.SetActive(true);
        RightRayCast.SetActive(true);
    }
    public void RayCastControllerOff()
    {
        LeftRayCast.SetActive(false);
        RightRayCast.SetActive(false);
    }
    public void ButtonAcessOn(int id)
    {
        ButtonAcess = true;
        if(id == 0)
        {
            DragObject[0].SetActive(false);
            HighLightParts[0].SetActive(false);
            TargetObjects[0].GetComponent<MeshRenderer>().enabled = true;
        }
        if (id == 1)
        {
            DragObject[1].SetActive(false);
            HighLightParts[1].SetActive(false);
            TargetObjects[1].GetComponent<MeshRenderer>().enabled = true;
        }
        if (id == 2)
        {
            DragObject[2].SetActive(false);
            HighLightParts[2].SetActive(false);
            TargetObjects[2].GetComponent<MeshRenderer>().enabled = true;
        }
        if (id == 3)
        {
            DragObject[3].SetActive(false);
            HighLightParts[3].SetActive(false);
            TargetObjects[3].GetComponent<MeshRenderer>().enabled = true;
        }
        if (id == 4)
        {
            DragObject[4].SetActive(false);
            HighLightParts[4].SetActive(false);
            TargetObjects[4].GetComponent<MeshRenderer>().enabled = true;
        }


    }
}
