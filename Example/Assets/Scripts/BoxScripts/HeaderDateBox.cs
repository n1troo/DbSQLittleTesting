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

    public void SetValues(DBUsers dbUser)
    {
        foreach (var ss in dbUser.DBUserLevel.DBTranning)
        {
            this.WeekText.text = "WEEK: " + ss.Wekk.ToString();
            this.DayText.text = "DAY: " + ss.Day.ToString();
        }
    }
}
