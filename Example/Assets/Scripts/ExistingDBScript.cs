﻿using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using SQLite4Unity3d;
using System.Linq;
using UnityEngine.SceneManagement;

public class ExistingDBScript : MonoBehaviour
{
    public Transform HeaderPanel;
    public Transform ResultPanel;
    public Transform PanelTranningComplete;

    public GameObject HeaderDateBox;
    public GameObject ResultBox;
    public GameObject TimeBox;
 

    private GameObject LocalTimeBox;

    public static DBUsers LoggedUser { get; set; }
    
    private int HowManyTraningCountSet { get; set; }

    void Start()
    {
        //TODO: Ddodac obslugę jaki to user zostal wybrany, zalogowany
        LoggedUser = DataService.db.GetDbDBUsersByID(PlayerPrefs.GetInt("UserIdLogged"));

        AddPanelObjects();
        //Local.GetComponentInChildren<Text>().text = "User: " + ss.idUsers + " " + ss.Login;
        //Local.GetComponentInChildren<Button>().onClick.AddListener(delegate () { ShowWhatWasCliked(ss); });
    }

   
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
    }

    /// <summary>
    /// Dodawanie obiektów do panelów
    /// </summary>
    private void AddPanelObjects()
    {        
        GameObject Local = Instantiate(HeaderDateBox);
        Local.GetComponent<HeaderDateBox>().SetValues(LoggedUser);
        Local.transform.SetParent(HeaderPanel.transform,false);

        LocalTimeBox = Instantiate(TimeBox);
        LocalTimeBox.GetComponent<TimerScript>().RestTimeSec = (int)LoggedUser.DBUserLevel.TranningRestTime;
        LocalTimeBox.GetComponent<TimerScript>().FireEvent += ExistingDBScript_FireEvent;
        LocalTimeBox.transform.SetParent(ResultPanel.transform, false);

        foreach (DBTranning ss in DataService.db.GetUserDBTranning(LoggedUser))
        {
            GameObject LocalResult = Instantiate(ResultBox);
            LocalResult.GetComponentInChildren<ResultBox>().SetTranning(ss); 
            LocalResult.GetComponentInChildren<Button>().onClick.AddListener(delegate () { ShowWhatWasCliked(LocalResult, ss); });
            LocalResult.transform.SetParent(ResultPanel.transform, false);
            HowManyTraningCountSet++;
        }
    }

    private void ShowWhatWasCliked(GameObject localResult, DBTranning ss)
    {
        //Debug.Log(LoggedUser.TimerInProgress);
        if (CheckSetPosition(ss))
        { 
            localResult.GetComponentInChildren<ResultBox>().DestroyButton();
            this.LocalTimeBox.gameObject.GetComponent<TimerScript>().StartTimer(localResult, ss);
        }
        else
        {
            Debug.Log("Bledny SET!");
        }
    }

    private bool CheckSetPosition(DBTranning ss)
    {
        if (!LoggedUser.TimerInProgress)
        {
            if (LoggedUser.ActualSetPositon == 0 && ss.Set == 1)
            {
                LoggedUser.TimerInProgress = true;
                LoggedUser.ActualSetPositon = 2;
                return true;
            }
            if (LoggedUser.ActualSetPositon == ss.Set)
            {
                LoggedUser.TimerInProgress = true;
                LoggedUser.ActualSetPositon++;
                return true;
            }
            else return false;
        }
        else
        {
            return false;
        }
    }

    private void ExistingDBScript_FireEvent(object sender, EventArgs e)
    {
        //Debug.Log("HOW MANY" + HowManyTraningCountSet.ToString());
        //Debug.Log("POZYCJA" + LoggedUser.ActualSetPositon.ToString());
        
        LoggedUser.TimerInProgress = false;

        if((HowManyTraningCountSet + 1) == LoggedUser.ActualSetPositon)
        {
            PanelTranningComplete.gameObject.SetActive(true);
            LoginManager.LoggedUser.DBUserLevel.SetTranningComplete();
        }

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