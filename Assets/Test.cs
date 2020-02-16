using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int[] array = new int[5];

        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;

        //配列を順番に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        //配列を逆順に表示
        for (int i = 5; i > 0; i--)
        {
            Debug.Log(array[i - 1]);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}