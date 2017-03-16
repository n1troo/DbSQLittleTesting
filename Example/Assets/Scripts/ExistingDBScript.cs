using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class ExistingDBScript : MonoBehaviour
{
    public Transform DebugPanel;
    public Transform ResultPanel;
    public GameObject HeaderBox;
    public GameObject ResultBox;


    void Start()
    {
        var db = new DataService();
        foreach (var ss in db.DBUsers)
        {
            GameObject Local = Instantiate(HeaderBox);

            Local.GetComponentInChildren<Text>().text = "User: " + ss.idUsers + " " + ss.Login;
            Local.GetComponentInChildren<Button>().onClick.AddListener(delegate () { ShowWhatWasCliked(ss); });
            Local.transform.SetParent(DebugPanel);
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
