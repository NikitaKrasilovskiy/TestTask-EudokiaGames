using TMPro;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject monstr, rekord, reolad;
    private float ran, nextFite = 5f;
    [SerializeField] public int i = 0, j = 0;
    private bool go = true;
    public TextMeshProUGUI monstrText, schetText;
    private AudioSource audioSource;
    void Update()
    {
        if (Time.time > nextFite && go)
        {
            ran = Random.Range(0.5f, 5);
            nextFite = Time.time + ran;
            Instantiate(monstr, new Vector3(Random.Range(-75, -225), 5, Random.Range(-145, 120)), Quaternion.identity);
            i++;
            audioSource = GetComponent<AudioSource>();
        }

        monstrText.text = "" + i;
        schetText.text = "" + j;

        if (i >= 10)
        {
            go = false;
            rekord.SetActive(true);
            reolad.SetActive(true);
        }

        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
    public void SoudAttack()
    {
        audioSource.Play();
    }
}
