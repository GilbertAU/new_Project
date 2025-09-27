using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTree : MonoBehaviour
{
    public static int TreeCount = 100;
    public GameObject TreeDisplay;
    public int InternalTree;
    public static int TreeGrowth = 10;

    private void Update()
    {
        InternalTree = TreeCount;
        TreeDisplay.GetComponent<Text>().text = "" + InternalTree;
    }
}
