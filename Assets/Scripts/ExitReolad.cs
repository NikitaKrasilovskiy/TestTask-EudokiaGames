using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitReolad : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }
    public void Reload()
    {
        SceneManager.LoadScene(0);
    }
}