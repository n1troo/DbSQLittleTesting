using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : AutoReferencer<TimerScript>
{
    public Slider SliderTimer;
    public event EventHandler FireEvent;
    float timer = 0;
    // Use this for initialization
    IEnumerator TimerStart(GameObject localResult)
    {
        SliderTimer.maxValue = 100;
        SliderTimer.value = 0;

        while (true)
        {
          
            timer =+ 5;
            SliderTimer.value += timer;

            if(SliderTimer.value >= 100)
            {
                Debug.Log("100%");
                localResult.gameObject.GetComponent<Image>().color = Color.blue;
                ChangeStatusThread();
                break;
            }

            yield return new WaitForSeconds(0.1f);
        }
    }

    public void ChangeStatusThread()
    {
        if (FireEvent != null)
            FireEvent(this, null);
    }

    public void StartTimer(GameObject localResult, DBTranning ss)
    {
        StartCoroutine(TimerStart(localResult));
    }
}
