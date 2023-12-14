using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    //

    public Transform playerCam;
    public Transform player;

    public bool rightHand = false;
    public bool leftHand = false;
    public float throwForce = 10;

    public bool hasPlayer = false;
    public bool beingCarried = false;
    public bool touched = false;



    private void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
    
        if(dist <= 1.7f)
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }

        if (hasPlayer /*&& !rightHand */&& Input.GetMouseButton(1))
        {
            Debug.Log("aaaa");
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            beingCarried = true;
        }

        if (hasPlayer /*&& !leftHand */&& Input.GetMouseButton(0))
        {
            Debug.Log("aaaa");
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            beingCarried = true;
        }

        if (beingCarried)
        {
            if (touched)
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                touched = false;
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                rightHand = false;
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                GetComponent <Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
            }
        }
    }

    private void OnTriggerEnter()
    {
        if (beingCarried)
        {
            touched = true;
        }
    }
}
