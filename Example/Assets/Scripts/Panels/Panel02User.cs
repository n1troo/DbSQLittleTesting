using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel02User : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void ChangeValueRestTime(Text zmiana)
    {
        Debug.Log("ZMIENIAM REST TIME! Wartość: " + zmiana.text);

        DBUserLevel dbuserlevel = DataService.db.GetDBUserLevel(LoginManager.LoggedUser.idUsers);
        dbuserlevel.TranningRestTime = Convert.ToInt32(zmiana.text);
        DataService.db.UpdateDBUserLevel(dbuserlevel);
    }
}
