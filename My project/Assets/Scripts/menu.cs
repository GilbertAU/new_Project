using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public static bool isLoading = false;

    public void NewGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadGame()
    {
        isLoading = true;
        SceneManager.LoadScene("Game");
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Quitting....");
    }
}