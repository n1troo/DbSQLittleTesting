using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultBox : AutoReferencer<ResultBox>
{
    public Text Text_Set;
    public Text Text_Reps;
    public Button ButtonRest;
    public bool TimerInProgress;
    public event EventHandler OnDestroyButton;

    public void SetTranning(DBTranning ss)
    {
        Text_Set.text = "Set: "+ ss.Set.ToString();
        Text_Reps.text = "Reps: " + ss.Reps.ToString();
    }

    public void DestroyButton()
    {
        Debug.Log("Destroy button!");
        DestroyImmediate(ButtonRest.gameObject);

        if (OnDestroyButton != null)
            OnDestroyButton(this, null);
    }
}
