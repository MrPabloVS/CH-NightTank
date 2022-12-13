using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    public static float[] HighscoreTable = new float[3];
    public static List<float> TimesList = new List<float>();
    public static float finishingTime;


    // Start is called before the first frame update
    void Start()
    {
        HighscoreTable[0] = 0f;
        HighscoreTable[1] = 0f;
        HighscoreTable[2] = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void AddTime(float time)
    {
        TimesList.Add(time);
        if (time > HighscoreTable[0])
        {
            HighscoreTable[0] = time;

        } else if (time > HighscoreTable[1] )
        {
            HighscoreTable[1] = time;

        } else if (time > HighscoreTable[2] )
        {
            HighscoreTable[2] = time;

        }
        
    }

    public static void NavigateArray()
    {
        foreach (var i in HighscoreTable)
        {
            Debug.Log(i);
        }
    }

    public static void NavigateArrayBackwards()
    {
        for (int i = 2; i < 0; i--)
        {
            Debug.Log(HighscoreTable[i]);
        }
    }

    public void setFinishTime()
    {
        finishingTime = StartLine.timer;
    }

}
