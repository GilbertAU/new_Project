using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButton : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton()
    {
        GlobalTree.TreeCount += 1;
    }
}
