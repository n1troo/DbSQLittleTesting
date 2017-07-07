using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLogoColor : MonoBehaviour
{
    //// Use this for initialization
    public Image ImageToTransform;
    //przeźroczysty
    Color32 ColorTo = new Color32(255, 255, 255, 100);
    Color32 ColorFrom = new Color32(255, 255, 255, 255);
    //bool uruchom = false;


    //IEnumerator Start()
    //{
    //    yield return new WaitForSeconds(2f);
    //    uruchom = true;
    //}

    void Update()
    { 
        //if(uruchom)
            ImageToTransform.color = Color.Lerp(ColorFrom, ColorTo, Mathf.PingPong(Time.time / 1f, 1f));

    }
}