using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class activities : MonoBehaviour
{
    public GameObject activity;
    public GameObject back;
    public GameObject chop;
    public GameObject manage;
    public GameObject sells;
    // Start is called before the first frame update
    void Start()
    {
        activity.SetActive(true);
        back.SetActive(false);
        chop.SetActive(false);
        manage.SetActive(false);
        sells.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackButton()
    {
        GlobalDays.DaysCount += 1;
        GlobalTree.TreeCount += GlobalTree.TreeGrowth;
        activity.SetActive(true);
        back.SetActive(false);
        chop.SetActive(false);
        manage.SetActive(false);
        sells.SetActive(false);
    }

    public void ChopButton()
    {
        activity.SetActive(false);
        back.SetActive(true);
        chop.SetActive(true);
        manage.SetActive(false);
        sells.SetActive(false);
    }

    public void ManageButton()
    {
        activity.SetActive(false);
        back.SetActive(true);
        chop.SetActive(false);
        manage.SetActive(true);
        sells.SetActive(false);
    }

    public void SellButton()
    {
        activity.SetActive(false);
        back.SetActive(true);
        chop.SetActive(false);
        manage.SetActive(false);
        sells.SetActive(true);
    }
}
