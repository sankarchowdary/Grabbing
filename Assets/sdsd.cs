using UnityEngine;

public class sdsd : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public float speed;

    void FixedUpdate()
    {
        //GetComponent<Rigidbody>().AddRelativeForce ((Vector3.right * 1 * speed) - GetComponent<Rigidbody>().velocity);
        GetComponent<Rigidbody>().AddForce(transform.right * speed, ForceMode.Acceleration);
    }
}
