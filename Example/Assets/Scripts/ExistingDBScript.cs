using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

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

    /// <summary>
    /// Dodawanie obiektów do panelów
    /// </summary>
    private void AddPanelObjects()
    {
        int idUser = 1;
        GameObject Local = Instantiate(HeaderDateBox);
        Local.GetComponent<HeaderDateStatus>().SetValues(idUser);
        Local.transform.SetParent(HeaderPanel);

        GameObject LocalTimeBox = Instantiate(TimeBox);
        LocalTimeBox.transform.SetParent(ResultPanel);

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
