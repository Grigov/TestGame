using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintSc : MonoBehaviour
{
    [SerializeField] private ScorePrint _Sc; // Убедитесь, что это поле назначено в инспекторе

    void Start()
    {
        if (_Sc != null)
        {
            _Sc.sc = DataHolder.DataH;
        }
        else
        {
            Debug.LogError("ww");
        }
    }
}