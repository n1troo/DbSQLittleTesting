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
        
        this.WeekText.text = "WEEK: " + dbUser.DBUserLevel.TranningWeek.ToString();
        this.DayText.text = "DAY: " + dbUser.DBUserLevel.TranningDay.ToString();
        
    }
}
