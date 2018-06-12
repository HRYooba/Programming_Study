using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example5 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        string result = "";
        for (int y = 1; y <= 9; y++)
        {
            for (int x = 1; x <= 9; x++)
            {
                result += " " + (y * x).ToString();
            }
            result += "\r\n";
        }
        Debug.Log(result);
    }
}
