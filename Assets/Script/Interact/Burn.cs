using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    //public GameObject monster;


    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.F))
        {
            if (((object1 = true) && (object2 = true) && (object3 = true) && (object4 = true) && (object5 = true)))
            {
                Debug.Log("nnn");

                SceneManager.LoadScene(NameOfScene);
            }
        }*/

        if(burn == 5)
        {
            Debug.Log("nnn");
            SceneManager.LoadScene(NameOfScene);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Object1")
        {
            Object1.SetActive(false);
            //object1 = true;
            //Destroy(Object1.gameObject);
            burn++;
        }
        if (collision.gameObject.CompareTag("Object2"))
        {
            Object2.SetActive(false);
            //object2 = true;
            // Destroy(Object2.gameObject);
            burn++;
        }
        if (collision.gameObject.CompareTag("Object3"))
        {
            Object3.SetActive(false);
            object3 = true;
            //Destroy(Object3.gameObject);
            burn++;
        }
        if (collision.gameObject.CompareTag("Object4"))
        {
            Object4.SetActive(false);
            object4 = true;
            //Destroy(Object4.gameObject);
            burn++;

        }
        if (collision.gameObject.CompareTag("Object5"))
        {
            Object5.SetActive(false);
            object5 = true;
            //Destroy(Object5.gameObject);
            burn++;
        }  
    }
}
