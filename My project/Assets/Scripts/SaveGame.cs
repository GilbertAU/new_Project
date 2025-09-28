using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveGame : MonoBehaviour
{
    public GameObject saveButton;

    public void SaveTheGame()
    {
        Debug.Log("Game Saved");
        PlayerPrefs.SetInt("SavedTree", GlobalTree.TreeCount);
        PlayerPrefs.SetInt("SavedTreeGrowth", GlobalTree.TreeGrowth);
        PlayerPrefs.SetInt("SavedChopped", GlobalChopped.ChoppedCount);
        PlayerPrefs.SetInt("SavedChoppedGrowth", GlobalChopped.ChoppedGrowth);
        PlayerPrefs.SetInt("SavedCash", GlobalCash.CashCount);
        PlayerPrefs.SetInt("SavedCashGrowth", GlobalCash.CashGrowth);
        PlayerPrefs.SetInt("SavedDays", GlobalDays.DaysCount);
        SceneManager.LoadScene("Start");
    }
}
