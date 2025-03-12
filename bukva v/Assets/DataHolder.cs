using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class DataHolder
{
    private static int _dataH;
    private static int _dataToEnter;

    public static int DataH
    {
        get
        {
            return _dataH;
        }

        set
        {
            _dataH = value;
        }
    }
    public static int DataToEnter
    {
        get
        {
            return _dataToEnter;
        }

        set
        {
            _dataToEnter = value;
        }
    }
}