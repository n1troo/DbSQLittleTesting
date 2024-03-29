﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panel02Manager : MonoBehaviour
{
    public Transform PanelContentMiddle;
    public GameObject Panel02User;
    public GameObject Panel02Settins;
    public GameObject Panel02PushUPScheduler;
    public GameObject Panel02About;
    // Use this for initialization


    private void Awake()
    {
        Application.targetFrameRate = 30;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }

    private void Start()
    {
        //Adding FIRST PANEL
        AddPanel("Panel02User");
    }

    /// <summary>
    /// Adding panels to PanelContentMiddle by name of gameobject
    /// </summary>
    /// <param name="namePanel"></param>
    public void AddPanel(string namePanel)
    {
        GameObject Local = null;
        if (PanelContentMiddle.transform.childCount > 0)
        {
            foreach (Transform ss in PanelContentMiddle)
            {
                if(ss.name.Contains(namePanel)){ return; }
                GameObject.DestroyObject(ss.gameObject);
            }
        }

        if (namePanel == "Panel02User")
        {
            Local = Instantiate(Panel02User);
        }
        else if (namePanel == "Panel02Settins")
        {
            Local = Instantiate(Panel02Settins);
        }
        else if(namePanel == "Panel02PushUPScheduler")
        {
            Local = Instantiate(Panel02PushUPScheduler);
        }
        else if (namePanel == "Panel02About")
        {
            Local = Instantiate(Panel02About);
        }

        Local.transform.SetParent(PanelContentMiddle.transform, false);
    }
}
