using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChopButton : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton()
    {
        if (GlobalTree.TreeCount < 10)
        {
            SceneManager.LoadScene("BadEnd");
        }
        else
        {
            GlobalTree.TreeCount -= 3;
            GlobalChopped.ChoppedCount += GlobalChopped.ChoppedGrowth;
        }
    }
}
