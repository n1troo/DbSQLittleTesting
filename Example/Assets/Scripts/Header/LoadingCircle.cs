using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingCircle : MonoBehaviour
{
    public Text ClockName;
    public Text ClockValue;
    public Color ClockProggresColor;
    public Image CircleImageComponent;

    private void Start()
    {
        CircleImageComponent.color = ClockProggresColor;
    }

    public void SetNameCircle(string valueName)
    {
        ClockName.text = valueName;
    }
    public void SetAmount(int value, int maximumValue)
    {

    }
}
