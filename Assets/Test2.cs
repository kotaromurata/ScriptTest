﻿using UnityEngine;
using System.Collections;

public class Boss
{
    private int mp = 53;

    public void Magic() { 
            if (mp < 5)
            {
                Debug.Log("MPが足りません");
            }
            else
            {
                mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + mp);
            }
    }
}

public class Test2 : MonoBehaviour
{
    void Start()
    {
        Boss lastboss = new Boss();

        for (int i = 0; i < 12 ; i++)
            lastboss.Magic();
    }

    // Update is called once per frame
    void Update()
    {

    }
}