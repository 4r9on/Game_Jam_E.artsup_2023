using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fleshlight : MonoBehaviour
{
    public void OnFlashlightToggle()
    {
        Light flashlight = GetComponent<Light>();

        if (flashlight.enabled)
        {
            flashlight.enabled = false;
        }

        else
        {
            flashlight.enabled = true;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            OnFlashlightToggle();
        }
    }
}
