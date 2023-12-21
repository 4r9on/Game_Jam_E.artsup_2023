using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MainMenu : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        audioSource.Play();

    }

    public void SwitchScene(string NameOfScene)
    {
        SceneManager.LoadScene(NameOfScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
