using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Interact : MonoBehaviour
{
    Burn fire;

    public GameObject text;
    public GameObject col;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {  
            text.SetActive(true);    
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.SetActive(false);

            col.SetActive(false);
        } 
    }
}
