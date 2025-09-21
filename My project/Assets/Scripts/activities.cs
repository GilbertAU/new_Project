using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class activities : MonoBehaviour
{
    public GameObject chop;
    public GameObject manage;
    public GameObject sell;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChopButton(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ManageButton(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void SellButton(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
