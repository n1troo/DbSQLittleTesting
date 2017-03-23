﻿using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using SQLite4Unity3d;
using System.Linq;

public class ExistingDBScript : MonoBehaviour
{
    public Transform HeaderPanel;
    public Transform ResultPanel;

    public GameObject HeaderDateBox;
    public GameObject ResultBox;
    public GameObject TimeBox;
    
    public Text VersionText;

    private GameObject LocalTimeBox;

    public static DBUsers LoggedUser { get; set; }

    void Start()
    {
        //TODO: Ddodac obslugę jaki to user zostal wybrany, zalogowany

        AddPanelObjects();
        SetVersion();
        //Local.GetComponentInChildren<Text>().text = "User: " + ss.idUsers + " " + ss.Login;
        //Local.GetComponentInChildren<Button>().onClick.AddListener(delegate () { ShowWhatWasCliked(ss); });
    }

    private void SetVersion()
    {
        VersionText.text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) { Application.Quit(); }
    }

    /// <summary>
    /// Dodawanie obiektów do panelów
    /// </summary>
    private void AddPanelObjects()
    {        
        LoggedUser = DataService.db.GetDbDBUsersByID(1);

        GameObject Local = Instantiate(HeaderDateBox);
        Local.GetComponent<HeaderDateBox>().SetValues(LoggedUser);
        Local.transform.SetParent(HeaderPanel.transform,false);

        LocalTimeBox = Instantiate(TimeBox);
        LocalTimeBox.GetComponent<TimerScript>().FireEvent += ExistingDBScript_FireEvent;
        LocalTimeBox.transform.SetParent(ResultPanel.transform, false);

        foreach (DBTranning ss in DataService.db.GetUserDBTranning(LoggedUser))
        {
            GameObject LocalResult = Instantiate(ResultBox);
            LocalResult.GetComponent<ResultBox>().SetTranning(ss); 
            LocalResult.GetComponentInChildren<Button>().onClick.AddListener(delegate () { ShowWhatWasCliked(LocalResult, ss); });
            LocalResult.transform.SetParent(ResultPanel.transform, false);
        }
    }

    private void ShowWhatWasCliked(GameObject localResult, DBTranning ss)
    {
        this.LocalTimeBox.gameObject.GetComponent<TimerScript>().StartTimer(localResult, ss);
    }

    private void ExistingDBScript_FireEvent(object sender, EventArgs e)
    {
        //throw new NotImplementedException();
    }

    //private void ShowWhatWasCliked(DBTranning dbTranning)
    //{

    //    //if(ResultPanel.transform.childCount > 0)
    //    //{
    //    //    foreach (Transform ss in ResultPanel)
    //    //    {
    //    //        GameObject.DestroyObject(ss.gameObject);
    //    //    }
    //    //}
        
    //    //GameObject localResult = Instantiate(ResultBox);
    //    //localResult.name = user.Login;

    //    //foreach (Text ss in localResult.GetComponentsInChildren<Text>())
    //    //{
    //    //    if (ss.name == "Text_idUser")
    //    //    {
    //    //        ss.GetComponent<Text>().text = "ID: " + user.idUsers.ToString();
    //    //    }
    //    //    if (ss.name == "Text_AddDate")
    //    //    {
    //    //        ss.GetComponent<Text>().text = "AddDate: " + user.AddDate.ToString();
    //    //    }
    //    //}

    //    //localResult.transform.SetParent(ResultPanel);

    //}
}
