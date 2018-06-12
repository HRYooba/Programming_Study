using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        bool isLoop = true;
        while (isLoop)
        {
            int dice1 = (int)Random.Range(1, 7); // 7は含まない 6.0fだと6を含む
            int dice2 = (int)Random.Range(1, 7);
            Debug.Log("dice1: " + dice1 + ", dice2: " + dice2);

            if (dice1 == dice2)
            {
                Debug.Log("ゾロ目だよー");
                isLoop = false;
            }
        }

        // break版
        // while (true)
        // {
        //     int dice1 = (int)Random.Range(1, 7);
        //     int dice2 = (int)Random.Range(1, 7);
        //     Debug.Log("dice1: " + dice1 + ", dice2: " + dice2);

        //     if (dice1 == dice2)
        //     {
        //         Debug.Log("ゾロ目だよー");
        //         break;
        //     }
        // }

    }
}
