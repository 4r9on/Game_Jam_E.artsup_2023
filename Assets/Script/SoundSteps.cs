using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

    public class footsteps : MonoBehaviour
    {
        public AudioSource footstepSound;
        public AudioSource sprintSound;
        /*public AudioSource wool, wood, grass;*/

        /* void OnCollisionEnter(Collision collision)
        {
           if (collision.gameObject.CompareTag("grass"))
            {   
                grass.Play();
            }
           if (collision.gameObject.CompareTag("wool"))
            {
                wool.Play();
            }
            if (collision.gameObject.CompareTag("wood"))
            {
                wood.Play();
            }
        }*/

        void Update()
        {
            
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    footstepSound.enabled = false;
                    sprintSound.enabled = true;
                }
                else
                {
                    footstepSound.enabled = true;
                    sprintSound.enabled = false;
                }
            }
            else
            {
                footstepSound.enabled = false;
                sprintSound.enabled = false;
            }

            
        }
    }


    
