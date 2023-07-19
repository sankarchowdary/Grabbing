using UnityEngine;
public class LineUpdate : MonoBehaviour
{

    public Transform StartPos;
    public Transform EndPos;
    LineRenderer Line;


    // Start is called before the first frame update
    void Start()
    {
        Line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 SPos = StartPos.position;
        Vector3 EPos = EndPos.position;
        Line.SetPosition(0, SPos);

        Line.SetPosition(1, EPos);
    }
}
