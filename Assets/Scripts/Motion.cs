using UnityEngine;

public class Motion : MonoBehaviour
{
    public GameObject stena, stena2, stena3, stena4;
    private float pos, pos2, pos3, pos4;
    void Start()
    {
    }
    void Update()
    {
        pos = stena.transform.position.x;
        if (pos < -235)
        {
            stena.transform.Translate(0, 5 * Time.deltaTime, 0);
        }
        pos2 = stena2.transform.position.x;
        if (pos2 > -65)
        {
            stena2.transform.Translate(0, 5 * Time.deltaTime, 0);
        }
        pos3 = stena3.transform.position.z;
        if (pos3 > 155)
        {
            stena3.transform.Translate(0, 5 * Time.deltaTime, 0);
        }
        pos4 = stena4.transform.position.z;
        if (pos4 < -155)
        {
            stena4.transform.Translate(0, 5 * Time.deltaTime, 0);
        }
    }
}
