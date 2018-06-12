using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // int count = 1;
        // while (count <= 100)
        // {
        //     Debug.Log(count);
        //     count++;
        // }


        // for (int i = 1; i <= 100; i++)
        // {
        //     Debug.Log(i);
        // }


        string result = "";
        for (int i = 1; i <= 100; i++)
        {
            result += " " + i.ToString();
            if (i % 10 == 0)
            {
                result += "\r\n";
            }
        }
        Debug.Log(result);
    }
}
