using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracObject : MonoBehaviour
{

    private bool hasObject;

    public GameObject objects1;
    public GameObject objects2;
    public GameObject objects3;
    public GameObject objects4;
    public GameObject objects5;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hasObject)
        {
            if(other.gameObject.name == "crane")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    objects1.SetActive(true);
                }


            }
            
        }
    }
}
