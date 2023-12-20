using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public GameObject Lampe;
    public int lamp;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) 
        {       
            Lampe.SetActive(true);
        }
        else
        {
            Lampe.SetActive(false);
        }

    }
}
