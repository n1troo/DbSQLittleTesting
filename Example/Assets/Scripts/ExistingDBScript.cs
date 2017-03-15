using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class ExistingDBScript : MonoBehaviour
{
    public Transform DebugPanel;
    public GameObject DebugText;


    void Start()
    {
        var db = new DataService();
        foreach (var ss in db.DBUsers)
        {
            GameObject Local = Instantiate(DebugText);

            Local.GetComponentInChildren<Text>().text = "User: " + ss.idUsers + " " + ss.Login;
            Local.GetComponentInChildren<Button>().onClick.AddListener(delegate () { ShowWhatWasCliked(ss); });
            Local.transform.SetParent(DebugPanel);
        }
    }

    private void ShowWhatWasCliked(DBUsers ss)
    {
        Debug.Log(ss.Login);
    }
}
