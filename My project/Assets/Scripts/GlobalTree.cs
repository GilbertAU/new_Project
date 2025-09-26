using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTree : MonoBehaviour
{
    public static int TreeCount;
    public GameObject TreeDisplay;
    public int InternalTree;

    private void Update()
    {
        InternalTree = TreeCount;
        TreeDisplay.GetComponent<Text>().text = "" + InternalTree;
    }
}
