using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Impact : MonoBehaviour
{
    private int Life = 2;
    public string NameOfScene;
    public GameObject Heart1;
    public GameObject Heart2;

    private void OnCollisionEnter(Collision collision)
    {
        

        if (collision.gameObject.CompareTag("Player"))
        {
            Life--;

            if (Life == 1)
            {
                Heart1.SetActive(false);
            }
            if (Life == 0)
            {
                SceneManager.LoadScene(NameOfScene);
            }

        }
    }
}
