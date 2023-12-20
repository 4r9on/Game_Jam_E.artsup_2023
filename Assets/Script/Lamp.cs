using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public GameObject Lampe;
    public float lamp;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R)) 
        {       
            Lampe.SetActive(true);
           /* lamp++;

            if (lamp >= 50)
            {
                Lampe.SetActive(false);
                lamp = 0;
            }*/
        }
        if (Input.GetKeyUp(KeyCode.R)) 
        {
            Lampe.SetActive(false);
        }
    }
}
