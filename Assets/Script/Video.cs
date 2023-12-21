using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    public string NameOfScene;

    private void Start()
    {
        StartCoroutine(Scream());
    }

    IEnumerator Scream()
    {
        yield return new WaitForSecondsRealtime(9f);
        SwitchScene();

    }

    public void SwitchScene()
    {
        SceneManager.LoadScene(NameOfScene);
    }
}
