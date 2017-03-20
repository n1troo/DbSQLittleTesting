using UnityEngine;
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


    void Start()
    {
        //TODO: Ddodac obslugę jaki to user zostal wybrany, zalogowany

        AddPanelObjects();
        //Local.GetComponentInChildren<Text>().text = "User: " + ss.idUsers + " " + ss.Login;
        //Local.GetComponentInChildren<Button>().onClick.AddListener(delegate () { ShowWhatWasCliked(ss); });
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
        int idUser = 1;
        GameObject Local = Instantiate(HeaderDateBox);
        Local.GetComponent<HeaderDateBox>().SetValues(idUser);
        Local.transform.SetParent(HeaderPanel.transform,false);

        GameObject LocalTimeBox = Instantiate(TimeBox);
        LocalTimeBox.transform.SetParent(ResultPanel.transform,false);


        var db = new DataService();
        DBUserLevel usrLvl = db.DBUserLevel().Where(s => s.idUsers == idUser).FirstOrDefault();

        foreach (DBTranning ss in db.GetDBTranningsByLvl(usrLvl))
        {
            GameObject LocalResult = Instantiate(ResultBox);
            LocalResult.GetComponent<ResultBox>().SetTranning(ss);
            LocalResult.transform.SetParent(ResultPanel.transform,false);
        }
    }

    private void ShowWhatWasCliked(DBUsers user)
    {

        if(ResultPanel.transform.childCount > 0)
        {
            foreach (Transform ss in ResultPanel)
            {
                GameObject.DestroyObject(ss.gameObject);
            }
        }
        
        GameObject localResult = Instantiate(ResultBox);
        localResult.name = user.Login;

        foreach (Text ss in localResult.GetComponentsInChildren<Text>())
        {
            if (ss.name == "Text_idUser")
            {
                ss.GetComponent<Text>().text = "ID: " + user.idUsers.ToString();
            }
            if (ss.name == "Text_AddDate")
            {
                ss.GetComponent<Text>().text = "AddDate: " + user.AddDate.ToString();
            }
        }

        localResult.transform.SetParent(ResultPanel);

    }
}
