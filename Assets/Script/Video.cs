using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Scream());
    }

    IEnumerator Scream()
    {
        yield return new WaitForSecondsRealtime(9f);
        SceneManager.LoadScene("_Lose");

    }
}
