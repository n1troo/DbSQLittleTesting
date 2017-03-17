using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class HeaderDateBox : MonoBehaviour
{
    public UnityEngine.UI.Text WeekText;
    public UnityEngine.UI.Text DayText;
    // Use this for initialization

    public void SetValues(int idUser)
    {
        var db = new DataService();

        foreach (var ss in db.DBUserLevel().Where(s=>s.idUsers == idUser))
        {
            this.WeekText.text = "WEEK: " + ss.TranningWeek.ToString();
            this.DayText.text = "DAY: " + ss.TranningDay.ToString();
        }
    }
}
