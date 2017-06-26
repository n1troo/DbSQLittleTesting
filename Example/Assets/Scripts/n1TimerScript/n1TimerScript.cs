using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class n1TimerScript : MonoBehaviour {

    public Text counterText;
    public float startCounterValue;
    public Color32 counterColor;

    private void Start()
    {
        StartCoroutine("StartCounter");
        Application.runInBackground = true;
        
    }

    IEnumerator StartCounter()
    {
        yield return new WaitForSeconds(1f);
        counterText.color = counterColor;
        startCounterValue += 1f;
        DateTime ts = new DateTime(TimeSpan.FromSeconds(startCounterValue).Ticks);
        counterText.text = string.Format("{0:D2}:{1:D2}", ts.Minute, ts.Second);
        StartCoroutine("StartCounter");
    }
}
