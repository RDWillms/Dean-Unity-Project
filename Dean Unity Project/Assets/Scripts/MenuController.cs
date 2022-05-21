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
    
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Grabs the buildIndex of the current scene and adds it by one to laod the next scene in the build settings.
    }
}

