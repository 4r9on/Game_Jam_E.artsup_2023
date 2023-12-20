using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Burn : MonoBehaviour
{
    public int burn;

    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;
    public GameObject Object4;
    public GameObject Object5;

    public bool object1 = false;
    public bool object2 = false;
    public bool object3 = false;
    public bool object4 = false;
    public bool object5 = false;

    public string NameOfScene;
    public GameObject monster;

    AIController controller;

    //public GameObject hasObject;
    //public GameObject notObject;

    private void Update()
    {
        if (burn == 1)
        {
            monster.SetActive(true);
        }
        if (burn == 3)
        {
            controller.agent.speed = 3.5f;
        }
        if (burn == 4)
        {
            controller.agent.speed = 5.0f;
        }
        if (burn == 5)
        {
            Debug.Log("nnn");
            SceneManager.LoadScene(NameOfScene);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Object1"))
        {
            Object1.SetActive(false);
            object1 = true;
            //Destroy(Object1.gameObject);
            burn++;
        }
        if (other.CompareTag("Object2"))
        {
            Object2.SetActive(false);
            object2 = true;
            // Destroy(Object2.gameObject);
            burn++;
        }
        if (other.CompareTag("Object3"))
        {
            Object3.SetActive(false);
            object3 = true;
            //Destroy(Object3.gameObject);
            burn++;
        }
        if (other.CompareTag("Object4"))
        {
            Object4.SetActive(false);
            object4 = true;
            //Destroy(Object4.gameObject);
            burn++;

        }
        if (other.CompareTag("Object5"))
        {
            Object5.SetActive(false);
            object5 = true;
            //Destroy(Object5.gameObject);
            burn++;
        }

        /*if (other.CompareTag("Player"))
        {
            if ((object1 = true) || (object2 = true) || (object3 = true) || (object3 = true) || (object4 = true) || (object5 = true))
            {
                hasObject.SetActive(true);
            }
            else
            {
                hasObject.SetActive(false);
            }

            if ((object1 = false) || (object2 = false) || (object3 = false) || (object3 = false) || (object4 = false) || (object5 = false))
            {
                notObject.SetActive(true);
            }
            else
            {
                notObject.SetActive(false);
            }
        }*/

    }
}
