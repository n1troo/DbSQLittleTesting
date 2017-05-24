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
    public int RestTimeSec { get; set; }
    public Text TextValue;

    IEnumerator TimerStart(GameObject localResult)
    {
        SliderTimer.maxValue = RestTimeSec;
        SliderTimer.value = 0;

        while (true)
        {
            //Debug.Log("CZAS: " + SliderTimer.value);
            
            SliderTimer.value += timer;
            TextValue.text = SliderTimer.value.ToString();

            if (SliderTimer.value + 1 > RestTimeSec)
            {
                //Debug.Log("100%");
                localResult.gameObject.GetComponent<Image>().color = Color.blue;
                ChangeStatusThread();
                
                break;
            }

            yield return new WaitForSeconds(1.0f);

            timer = +1;
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
