using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalDays : MonoBehaviour
{
    public static int DaysCount = 1;
    public GameObject DaysDisplay;
    public int InternalDays;

    private void Update()
    {
        InternalDays = DaysCount;
        DaysDisplay.GetComponent<Text>().text = "Days:  " + InternalDays;
    }
}
