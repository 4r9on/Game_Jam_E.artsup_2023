using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    //

    public Transform playerCam;
    public Transform player;

    //public float throwForce = 10;

    public bool hasPlayer = false;
    public bool beingCarried = false;
    public bool touched = false;

    public Material[] outline;
    Renderer rend;


    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.material = outline[0];
    }

    private void Update()
    {

        float dist = Vector3.Distance(gameObject.transform.position, player.position);
    
        if(dist <= 1.7f)
        {
            hasPlayer = true;
            rend.material = outline[1];
            Debug.Log("kkkkkk");
        }
        else
        {
            hasPlayer = false;
        }

        if (hasPlayer && Input.GetMouseButton(0))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            beingCarried = true;
        }

        if (beingCarried)
        {
            if (touched)
            {
                GetComponent<Rigidbody>().isKinematic = true;
                transform.parent = null;
                beingCarried = false;
                touched = false;
            }

            /*if (Input.GetKeyDown(KeyCode.F))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
            }*/

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
