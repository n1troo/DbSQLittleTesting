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
        float day = ((uslvl.TranningWeek * 3) - 3 )  + uslvl.TranningDay;
        DayText.text = string.Format("{0}/18",day.ToString());
        Radial_Day.fillAmount =  ((day * 100f) / 18f) / 100;

        //UPDATE WEEK
        float week = uslvl.TranningWeek;
        WeekText.text = string.Format("{0}/6", week.ToString());
        Radial_Week.fillAmount = (week / 6f);
       
        //UPDATE LEVEL
        float level = uslvl.TranningLevel;
        LevelText.text = string.Format("{0}/3", level.ToString());
        Radial_Level.fillAmount = level / 3f ;




    }

}
