using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class UserSettings : MonoBehaviour {

    void Awake()
    {

        FillPanels();
    }
    private void FillPanels()
    {
        DBUserLevel localdbUser = LoginManager.LoggedUser.DBUserLevel;
        foreach (Transform groupPanel in this.GetComponentInChildren<Transform>())
        {
            Debug.Log(groupPanel.name);
            if (groupPanel.name == "UserLevelPanel")
            {
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
        }
    }
}
