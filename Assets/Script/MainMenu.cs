using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MainMenu : MonoBehaviour
{

    public void SwitchScene(string NameOfScene)
    {
        SceneManager.LoadScene(NameOfScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
