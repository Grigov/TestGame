using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePrint : MonoBehaviour
{
    private int Sc;
    private Text textScore;

    public int sc
    {
        get { return Sc; }
        set
        {
            Sc = value;
            if (textScore == null)
            {
                textScore = GetComponent<Text>();
            }
            textScore.text = $"Score: {Sc}";
        }
    }

    private void Start()
    {
        textScore = GetComponent<Text>();
    }
}