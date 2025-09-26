using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellTree : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton()
    {
        if (GlobalTree.TreeCount <= 0)
        {
            Debug.Log("No trees to sell");
        }
        else
        {
            GlobalTree.TreeCount -= 1;
            GlobalCash.CashCount += 5;
        }    
    }
}
