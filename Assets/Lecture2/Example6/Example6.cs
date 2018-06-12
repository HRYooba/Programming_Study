using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example6 : MonoBehaviour
{
    [SerializeField]
    GameObject cubePrefab;
    GameObject[] cubes = new GameObject[11];

    int selectNum = 0;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 11; i++)
        {
            Vector3 pos = new Vector3((1 + 0.5f) * (i - 5), 0, 0);
            Quaternion rot = Quaternion.identity;
            cubes[i] = Instantiate(cubePrefab, pos, rot);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            selectNum++;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            selectNum--;
        }

        for (int i = 0; i < 11; i++)
        {
            if (i == selectNum)
            {
                if (cubes[i] == null) continue;
                cubes[i].transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            }
            else
            {
                if (cubes[i] == null) continue;
                cubes[i].transform.localScale = new Vector3(1, 1, 1);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (selectNum < 0 || selectNum > 10) return;
            if (cubes[selectNum] == null) return;
            Destroy(cubes[selectNum]);
        }

    }
}
