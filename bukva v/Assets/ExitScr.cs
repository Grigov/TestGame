using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScr : MonoBehaviour
{
    public void DopExit()
    {
        SceneManager.LoadScene(1);
    }
    public void DopEnter()
    {
        if (DataHolder.DataToEnter == 1)
        {
            SceneManager.LoadScene(2);
        }
    }
}