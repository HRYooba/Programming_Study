using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example7 : MonoBehaviour
{
    [SerializeField]
    GameObject cubePrefab;
    GameObject[] cubes = new GameObject[100];
    Vector3[] mousePosBuff = new Vector3[100];


    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < cubes.Length; i++) // for (int i = 0; i < 100; i++) でも可能
        {
            Vector3 pos = new Vector3(0, 0, 0);
            Quaternion rot = Quaternion.identity;
            cubes[i] = Instantiate(cubePrefab, pos, rot);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 座標計算
        mousePosBuff[0] = Input.mousePosition;
        for (int i = 99; i > 0; i--)
        {
            if (i - 1 >= 0)
            {
                Vector3 tempPos = mousePosBuff[i - 1];
                mousePosBuff[i] = tempPos;
            }
        }

        // Cubeの描画
        for (int i = 0; i < cubes.Length; i++)
        {
            Vector3 screenPos = new Vector3(mousePosBuff[i].x, mousePosBuff[i].y, 10.0f);
            Vector3 cubePos = Camera.main.ScreenToWorldPoint(screenPos);
            cubes[i].transform.position = cubePos;
        }
    }
}
