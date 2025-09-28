using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public int savedTree;
    public int savedTreeGrowth;
    public int savedChopped;
    public int savedChoppedGrowth;
    public int savedCash;
    public int savedCashGrowth;
    public int savedDays;
    void Start()
    {
        if (menu.isLoading == true)
        {
            savedTree = PlayerPrefs.GetInt("SavedTree");
            GlobalTree.TreeCount = savedTree;
            savedTreeGrowth = PlayerPrefs.GetInt("SavedTreeGrowth");
            GlobalTree.TreeGrowth = savedTreeGrowth;
            savedChopped = PlayerPrefs.GetInt("SavedChopped");
            GlobalChopped.ChoppedCount = savedChopped;
            savedChoppedGrowth = PlayerPrefs.GetInt("SavedChoppedGrowth");
            GlobalChopped.ChoppedGrowth = savedChoppedGrowth;
            savedCash = PlayerPrefs.GetInt("SavedCash");
            GlobalCash.CashCount = savedCash;
            savedCashGrowth = PlayerPrefs.GetInt("SavedCashGrowth");
            GlobalCash.CashGrowth = savedCashGrowth;
            savedDays = PlayerPrefs.GetInt("SavedDays");
            GlobalDays.DaysCount = savedDays;
        }
        else
        {
            PlayerPrefs.SetInt("SavedTree", 100);
            PlayerPrefs.SetInt("SavedTreeGrowth", 10);
            PlayerPrefs.SetInt("SavedChopped", 0);
            PlayerPrefs.SetInt("SavedChoppedGrowth", 3);
            PlayerPrefs.SetInt("SavedCash", 0);
            PlayerPrefs.SetInt("SavedCashGrowth", 5);
            PlayerPrefs.SetInt("SavedDays", 1);
            PlayerPrefs.Save();

            GlobalTree.TreeCount = 100;
            GlobalTree.TreeGrowth = 10;
            GlobalChopped.ChoppedCount = 0;
            GlobalChopped.ChoppedGrowth = 3;
            GlobalCash.CashCount = 0;
            GlobalCash.CashGrowth = 5;
            GlobalDays.DaysCount = 1;
        }
    }
}
