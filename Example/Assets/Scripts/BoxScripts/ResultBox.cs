using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultBox : MonoBehaviour
{
    public Text TextSet;
    public Text TextReps;
    public Button Button;

    public void SetTranning(DBTranning ss)
    {
        TextSet.text = "Set: "+ ss.Set.ToString();
        TextReps.text = "Reps: " + ss.Reps.ToString();

    }

    public void DestroyButton()
    {
        Debug.Log("Destroy button!");
        DestroyImmediate(Button.gameObject);
    }
}
