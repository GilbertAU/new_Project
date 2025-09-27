using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagingButton : MonoBehaviour
{
    public GameObject Tree;
    public GameObject Chop;
    public GameObject Coin;
    public void TreeButton()
    {
        if (GlobalCash.CashCount <= 20)
        {
            Debug.Log("No Money");
        }
        else
        {
            GlobalCash.CashCount -= 20;
            GlobalTree.TreeGrowth += 3;
        }
    }

    public void ChopButton()
    {
        if (GlobalCash.CashCount <= 20)
        {
            Debug.Log("No Money");
        }
        else
        {
            GlobalCash.CashCount -= 20;
            GlobalChopped.ChoppedGrowth += 3;
        }
    }

    public void SellButton()
    {
        if (GlobalCash.CashCount <= 20)
        {
            Debug.Log("No Money");
        }
        else
        {
            GlobalCash.CashCount -= 20;
            GlobalCash.CashGrowth += 3;
        }
    }
}
