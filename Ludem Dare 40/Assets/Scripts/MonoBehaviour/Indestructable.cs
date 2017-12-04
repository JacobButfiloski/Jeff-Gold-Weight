using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Indestructable : MonoBehaviour
{

    public bool completed1;
    public bool completed2;
    public bool completed3;
    public bool completed4;
    public bool completed5;
    public bool completed6;
    public bool completed7;
    public bool completed8;
    public bool completed9;
    public bool completed10;
    public bool completed11;
    public bool completed12;
    public bool completed13;
    public bool completed14;
    public bool completed15;
    public bool completed16;
    public bool completed17;
    public bool completed18;
    public bool completed19;
    public bool completed20;
    public bool completed21;
    public bool completed22;
    public bool completed23;
    public bool completed24;

    public List<bool> boolList = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };

    private bool[] boolArray;
    public static Indestructable instance = null;
    // For sake of example, assume -1 indicates first scene
    //public int prevScene = -1;

    void Awake()
    {
        // If we don't have an instance set - set it now
        if (!instance)
            instance = this;
        // Otherwise, its a double, we dont need it - destroy
        else
        {
            Destroy(this.gameObject);
            return;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void ChangeBool(int boolToChange)
    {
        boolToChange -= 1;
        /*UpdateArray();
        for(int i = 0; i < boolArray.Length; i++)
        {
            if(boolArray[boolToChange] == i)
            {
                boolList[boolToChange] = true;
            }
        }*/

        boolList[boolToChange] = true;
    }

    void UpdateArray()
    {
        boolList.ToArray();
    }
}