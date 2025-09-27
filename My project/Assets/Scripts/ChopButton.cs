using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopButton : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton()
    {
        if (GlobalTree.TreeCount <= 0)
        {
            Debug.Log("No Tree");
        }
        else
        {
            GlobalTree.TreeCount -= 1;
            GlobalChopped.ChoppedCount += GlobalChopped.ChoppedGrowth;
        }
    }
}
