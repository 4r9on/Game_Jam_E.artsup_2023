using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator anim;

    public bool openDoor1 = false;
    bool openDoor2;
    bool openDoor3;

    public void Update()
    {
        if (openDoor1 = true && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("ttttt");
            openDoor1 = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door1"))
        {
            anim.SetBool("door1", true);

        }
        if (other.CompareTag("Door2"))
        {
            anim.SetBool("door2", true);

        }
        if (other.CompareTag("Door3"))
        {
            anim.SetBool("door3", true);

        }

    }


    void Door1()
    {
        
    }
}
