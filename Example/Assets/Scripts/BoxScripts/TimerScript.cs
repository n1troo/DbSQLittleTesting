using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Slider slider;
    public event EventHandler FireEvent;
    float timer = 0;
    // Use this for initialization
    IEnumerator TimerStart(GameObject localResult)
    {
        slider.maxValue = 100;
        slider.value = 0;

        while (true)
        {
          
            timer =+ 5;
            slider.value += timer;

            if(slider.value >= 100)
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
