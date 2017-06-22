using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : AutoReferencer<TimerScript>
{
    public Slider SliderTimer;
    public event EventHandler FireEvent; 
    public int RestTimeSec { get; set; }
    public Text TextValue;
    public AudioClip audioClipFinish;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    IEnumerator TimerStart(GameObject localResult)
    {
        SliderTimer.maxValue = RestTimeSec;
        SliderTimer.value = 0;

        while (true)
        {
            //Debug.Log("CZAS: " + SliderTimer.value);

            SliderTimer.value += 1;
            TextValue.text = SliderTimer.value.ToString();
            yield return new WaitForSeconds(1.0f);

            if (SliderTimer.value + 1 > RestTimeSec)
            {
                //Tick row is done
                localResult.gameObject.GetComponent<Image>().enabled = true;
                SliderTimer.value = 0;               
                ChangeStatusThread();
                TextValue.text = "0";
                break;
            }   
        }
    }

    public void ChangeStatusThread()
    {
        if (FireEvent != null)
            FireEvent(this, null);

        Debug.Log("start played");
        audioSource.Play();
        Debug.Log("end played");

    }

    public void StartTimer(GameObject localResult, DBTranning ss)
    {
        StartCoroutine(TimerStart(localResult));
    }
}
