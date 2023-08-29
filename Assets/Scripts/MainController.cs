using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainController : MonoBehaviour
{
    public GameObject[] DragObject;
    public GameObject[] HighLightParts;
    public GameObject[] ScrewsPart1;
    public GameObject[] ScrewsPart2;
    public Vector3 DragObjectRotation;
    public Vector3 DragObjectpostion;
    public GameObject[] button;
    public int i,ButtonCount;
    public GameObject LeftRayCast,RightRayCast;
    public static MainController Instance;
    public bool ButtonAcess;
    public GameObject[] TargetObjects;
    public TextMeshProUGUI InformationText;
    public Material MainScrewMat, GlowScrewMat;
    public Renderer[] col_rend;
    public Color oldcolor;
    public bool StopColorBlinking;
    public GameObject HandControllerScreen;
    public GameObject MainModuleScreen;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        ButtonAcess = true;
        StopColorBlinking = true;
        //  ScrewsPart1[i].GetComponent<Renderer>().material = GlowScrewMat;

    }
   public float timeLeft;
    public Color targetColor;
    public void Update()
    {
        if (StopColorBlinking)
        {
            // transition complete
            // assign the target color
            for (int i = 0; i < 7; i++)
            {
                if (timeLeft <= Time.deltaTime)
                {
                    ScrewsPart1[i].GetComponent<Renderer>().material.color = targetColor;

                    // start a new transition
                    targetColor = new Color(Random.value, Random.value, Random.value);
                    GlowScrewMat.color = targetColor;
                    timeLeft = 1.0f;
                }
                else
                {

                    // transition in progress
                    // calculate interpolated color
                    ScrewsPart1[i].GetComponent<Renderer>().material.color = Color.Lerp(ScrewsPart1[i].GetComponent<Renderer>().material.color, targetColor, Time.deltaTime / timeLeft);

                    // update the timer
                    timeLeft -= Time.deltaTime;
                    GlowScrewMat.color = targetColor;


                }
            }
        }
    }

    
   

    public void ButtonController(int id)
    {
        if (ButtonAcess)
        {
            ButtonCount++;
            LeftRayCast.SetActive(false);
            RightRayCast.SetActive(false);
            
            print(ButtonCount);
            for (i = 0; i < 5; i++)
            {
                button[i].GetComponent<Button>().interactable = false;
            }
            if (id == 0)
            {
                DragObject[0].SetActive(true);
                InformationText.text = "Pick The Object Place in Correct Manner";
                HighLightParts[0].SetActive(true);
                

            }
            else if (id == 1)
            {
                DragObject[1].SetActive(true);
                HighLightParts[1].SetActive(true);
                InformationText.text = "Pick The Object Place in Correct Manner";
            }
            else if (id == 2)
            {
                button[ButtonCount].GetComponent<Button>().interactable = true;
                DragObject[2].SetActive(true);
                HighLightParts[2].SetActive(true);
                InformationText.text = "Pick The Object Place in Correct Manner";
            }
            else if (id == 3)
            {
                button[ButtonCount].GetComponent<Button>().interactable = true;
                DragObject[3].SetActive(true);
                HighLightParts[3].SetActive(true);
                InformationText.text = "Pick The Object Place in Correct Manner";
            }
            else if (id == 4)
            {
                // button[ButtonCount].GetComponent<Button>().interactable = true;
                DragObject[4].SetActive(true);
                HighLightParts[4].SetActive(true);
                InformationText.text = "Pick The Object Place in Correct Manner";
            }
            ButtonAcess = false;
        }
    }
    // Update is called once per frame
    public void ScrewPart1()
    {
        for (int i = 0; i < 75; i++)
        {
             ScrewsPart2[i].GetComponent<Renderer>().material = MainScrewMat;
            button[ButtonCount].GetComponent<Button>().interactable = true;

            InformationText.text = "Click on Part2";


        }
     
    }
    public void ScrewPart2()
    {
        for (int i = 0; i < 7; i++)
        {
            print("test2");
            ScrewsPart1[i].GetComponent<Renderer>().material = MainScrewMat;
            button[ButtonCount].GetComponent<Button>().interactable = true;
            InformationText.text = "Click on Part3";
            StopColorBlinking = false;

        }
    }
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
        RayCastControllerOn();
        if (id == 0)
        {
            DragObject[0].SetActive(false);
            HighLightParts[0].SetActive(false);
            TargetObjects[0].GetComponent<MeshRenderer>().enabled = true;
            InformationText.text = "Tighen Screws by clicking on Screw";
            //  ScrewPart1();
        }
        if (id == 1)
        {
            DragObject[1].SetActive(false);
            HighLightParts[1].SetActive(false);
            TargetObjects[1].GetComponent<MeshRenderer>().enabled = true;
            InformationText.text = "Tighen Screws by clicking on Screw";

        }
        if (id == 2)
        {
            DragObject[2].SetActive(false);
            HighLightParts[2].SetActive(false);
            TargetObjects[2].GetComponent<MeshRenderer>().enabled = true;
            InformationText.text = "Click On Part4";
        }
        if (id == 3)
        {
            DragObject[3].SetActive(false);
            HighLightParts[3].SetActive(false);
            TargetObjects[3].GetComponent<MeshRenderer>().enabled = true;
            InformationText.text = "Click On Part5";
        }
        if (id == 4)
        {
            DragObject[4].SetActive(false);
            HighLightParts[4].SetActive(false);
            TargetObjects[4].GetComponent<MeshRenderer>().enabled = true;
            InformationText.text = "Click On Part6";
            HandControllerScreen.SetActive(true);
            MainModuleScreen.SetActive(false);

        }


    }
}
