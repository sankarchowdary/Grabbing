using System.Collections;
using UnityEngine;

public class RestrictedAreaTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject WarningMsg;
    public GameObject AlertLight;
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "BodyCollider")
        {
            WarningMsg.SetActive(true);
            StartCoroutine(ShowLight());
        }

    }


    private void OnTriggerExit(Collider other)
    {
        if (other.name == "BodyCollider")
        {
            WarningMsg.SetActive(false);
            StopAllCoroutines();
            AlertLight.SetActive(false);

        }

    }

    IEnumerator ShowLight()
    {
        for (int i = 0; i < 100; i++)
        {
            print("true");
            AlertLight.SetActive(true);
            yield return new WaitForSeconds(1f);
            AlertLight.SetActive(false);
            print("false");
        }
    }
}
