using UnityEngine;

public class Touch : MonoBehaviour
{
    private GameObject monstr;
    private Spawn spawnScript;
    private void Start()
    {
        monstr = this.gameObject;
        spawnScript = FindObjectOfType<Spawn>();
    }
    void OnMouseDown()
    {
        Destroy(monstr);
        spawnScript.i--;
        spawnScript.j++;
        spawnScript.SoudAttack();
    }
}