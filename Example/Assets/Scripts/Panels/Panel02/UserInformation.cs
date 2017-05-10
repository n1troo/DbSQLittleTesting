using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class UserInformation : MonoBehaviour
{
    // Use this for initialization
    void Awake ()
    {
        FillPanels();
	}

    private void FillPanels()
    {
        DBUserLevel localdbUser = LoginManager.LoggedUser.DBUserLevel;
        foreach (Transform groupPanel in this.GetComponentInChildren<Transform>())
        {
            Debug.Log(groupPanel.name);
            if (groupPanel.name == "UserLevelPanel") {
                groupPanel.GetComponentsInChildren<Text>().Where(s => s.name == "Text_Level").FirstOrDefault().text = localdbUser.TranningLevel.ToString();
            }
            if (groupPanel.name == "UserWeekPanel")
            {
                groupPanel.GetComponentsInChildren<Text>().Where(s => s.name == "Text_Level").FirstOrDefault().text = localdbUser.TranningWeek.ToString();
            }
            if (groupPanel.name == "UserDayPanel")
            {
                groupPanel.GetComponentsInChildren<Text>().Where(s => s.name == "Text_Level").FirstOrDefault().text = localdbUser.TranningDay.ToString();
            }
            if (groupPanel.name == "UserRestTimePanel")
            {
                groupPanel.GetComponentsInChildren<InputField>().FirstOrDefault().gameObject.GetComponentInChildren<Text>().text = localdbUser.TranningRestTime.ToString();
            }
            
        }
    }

    
}
