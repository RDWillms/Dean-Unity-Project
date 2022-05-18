using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void MenuSelect(string SceneName)
    { //If SceneName is blank quit game, if not, Load Scene declared in the public variable SceneName;
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

