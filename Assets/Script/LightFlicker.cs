using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public GameObject LTrigger;

    public GameObject Light;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;

    private void OnTriggerEnter(Collider LTrigger)
    {
        if (LTrigger.gameObject.CompareTag("Chien")) 
        {
            Light.SetActive(false);
            Light1.SetActive(false);
            Light2.SetActive(false);
            Light3.SetActive(false);
            Light4.SetActive(false);
        }
     

    }

    private void OnTriggerExit(Collider other)
    {
        if (LTrigger.gameObject.CompareTag("Chien"))
        {
            Light.SetActive(true);
            Light1.SetActive(true);
            Light2.SetActive(true);
            Light3.SetActive(true);
            Light4.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
