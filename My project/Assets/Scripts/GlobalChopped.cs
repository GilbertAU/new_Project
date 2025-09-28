using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GlobalChopped : MonoBehaviour
{
    public static int ChoppedCount = 0;
    public GameObject ChoppedDisplay;
    public int InternalChopped;
    public static int ChoppedGrowth = 3;

    private void Update()
    {
        InternalChopped = ChoppedCount;
        ChoppedDisplay.GetComponent<Text>().text = "" + InternalChopped;
    }
}
