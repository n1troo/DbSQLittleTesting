using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultBox : MonoBehaviour
{
    public Text TextSet;
    public Text TextReps;

    public void SetTranning(DBTranning ss)
    {
        TextSet.text = "Set: "+ ss.Set.ToString();
        TextReps.text = "Reps: " + ss.Reps.ToString();

    }
}
