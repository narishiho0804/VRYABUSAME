using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fenceGenerateScript : MonoBehaviour
{
    public GameObject prefab01;
    public GameObject prefab02;

    void Start()
    {
        if (prefab01)
        {
            for (int i = 0; i < 24; i++)
            {
                Instantiate(prefab01, new Vector3(i * 4.0F, 0, 1), Quaternion.identity);
            }
        }
        if (prefab02)
        {
            for (int i = 0; i < 24; i++)
            {
                Instantiate(prefab02, new Vector3(i * 4.0F, 0, -1), Quaternion.identity);
            }
        }
        //for (int i = 0; i < 30; i++)
        //{
        //    Instantiate(prefab, new Vector3(i * 3.0F , 0, 1), Quaternion.identity);
        //}
    }
}
