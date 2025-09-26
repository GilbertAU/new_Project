using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlovalDays : MonoBehaviour
{
    public static int DaysCount;
    public GameObject DaysDisplay;
    public int InternalDays;

    private void Update()
    {
        InternalDays = DaysCount;
        DaysDisplay.GetComponent<Text>().text = "Days:  " + InternalDays;
    }
}
