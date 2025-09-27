using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellTree : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton()
    {
        if (GlobalChopped.ChoppedCount <= 0)
        {
            Debug.Log("No Wood to sell");
        }
        else
        {
            GlobalChopped.ChoppedCount -= 1;
            GlobalCash.CashCount += GlobalCash.CashGrowth;
        }    
    }
}
