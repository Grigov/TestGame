using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptMenu : MonoBehaviour
{
    public void StartQuize()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitQuize()
    {
        Application.Quit();
    }
    public void RePlay()
    {
        SceneManager.LoadScene(1);
        DataHolder.DataH = 0;
    }
}
