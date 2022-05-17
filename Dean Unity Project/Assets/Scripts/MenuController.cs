using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void MenuSelect(string SceneName)
    {
        if(SceneName == "")
        {
            Application.Quit();
            Debug.Log("Quit");
        }
        else
        {
            SceneManager.LoadScene(SceneName);
        }
    }  
}

