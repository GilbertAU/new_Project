using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    public static int CashCount = 0;
    public GameObject CashDisplay;
    public int InternalCash;
    public static int CashGrowth = 5;

    private void Update()
    {
        InternalCash = CashCount;
        CashDisplay.GetComponent<Text>().text = "" + InternalCash;
    }
}
