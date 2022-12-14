using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHud : MonoBehaviour
{
    public Text timerText;

    void Update()
    {
        
        timerText.text = "Time: " + StartLine.timer.ToString("#.00");

    }
}
