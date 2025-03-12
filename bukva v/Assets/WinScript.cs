using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public void Win()
    {
        if (DataHolder.DataH >= 20)
        {
            SceneManager.LoadScene(3);
        }
    }
}
