using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public Time;
private float secondsCount;
private int minuteCount;

void Update()
{
    UpdateTimerUI();
}

public void UpdateTimerUI()
{

    timerText.text = minuteCount.ToString("00") + "m:" + ((int)secondsCount).ToString("00") + "s";

}
}