using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressLoadingCircle : MonoBehaviour
{

    public Text DayText;
    public Image Radial_Day;

    public Text WeekText;
    public Image Radial_Week;

    public Text LevelText;
    public Image Radial_Level;

    public void UpdateProgressCircles(DBUserLevel uslvl)
    {
        //UPDATE DAY
        float day = (uslvl.TranningDay * uslvl.TranningWeek);
        DayText.text = string.Format("{0}/18",day.ToString());
        Radial_Day.fillAmount = (18f * day) / 100;

        //UPDATE WEEK
        float week = uslvl.TranningWeek;
        WeekText.text = string.Format("{0}/6", week.ToString());
        Radial_Week.fillAmount = (6f * week) / 100;

        //UPDATE LEVEL
        float level = uslvl.TranningLevel;
        WeekText.text = string.Format("{0}/3", level.ToString());
        Radial_Week.fillAmount = (3f * level) / 100;





    }

}
