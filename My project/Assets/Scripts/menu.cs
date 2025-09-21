using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject menupanel;
    public GameObject settingspanel;
    // Start is called before the first frame update
    void Start()
    {
        menupanel.SetActive(true);
        settingspanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartButton(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void SettingsButton()
    {
        menupanel.SetActive(false);
        settingspanel.SetActive(true);
    }

    public void BackButton()
    {
        menupanel.SetActive(true);
        settingspanel.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Quitting....");
    }
}
