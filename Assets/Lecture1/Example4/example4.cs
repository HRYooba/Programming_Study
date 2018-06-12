using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example4 : MonoBehaviour
{
    [SerializeField]
    GameObject cubePrefab;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Vector3 pos = new Vector3((1 + 0.5f) * (i - 50), 0, 0);
            Quaternion rot = Quaternion.identity;
            Instantiate(cubePrefab, pos, rot);
        }
    }
}
