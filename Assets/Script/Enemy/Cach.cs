using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cach : MonoBehaviour
{
    AIController controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           // controller.detecDistance = 0;
        }
    }
}
