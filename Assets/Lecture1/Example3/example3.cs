using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example3 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Calculation1();
        Calculation2();
        Calculation3();
    }

    // 1から500までの和を計算してみましょう
    void Calculation1()
    {
        int sum = 0;
        for (int i = 1; i <= 500; i++)
        {
            sum += i;
        }
        Debug.Log("Calculation1: " + sum);
    }

    // 1から1000までの偶数の和を計算してみましょう
    void Calculation2()
    {
        int sum = 0;
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }

        }
        // for (int i = 2; i <= 1000; i+=2)
        // {
        //     sum += i;
        // }
        Debug.Log("Calculation2: " + sum);
    }

    // 1から1000までの奇数の和を計算してみましょう
    void Calculation3()
    {
        int sum = 0;
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 2 == 1)
            {
                sum += i;
            }

        }
        // for (int i = 1; i <= 1000; i+=2)
        // {
        //     sum += i;
        // }
        Debug.Log("Calculation3: " + sum);
    }
}
