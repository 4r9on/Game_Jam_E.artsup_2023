using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutch : MonoBehaviour
{
    Burn fire;

    //public GameObject text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (fire.burn == 0)
            {
                Debug.Log("pppppppp");
                //text.SetActive(true);
            }
            else if (fire.burn <= 1)
            {
                //text.SetActive(false);
            }
        }
        
    }
}
