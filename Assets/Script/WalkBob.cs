using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class WalkBob : MonoBehaviour
{
    public float SpeedWalkBobbing = 10f;
    public float BobbingAmount = 1f;
    public FirstPersonController Controller;

    float defaultPosY = 0f;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Mathf.Abs(Controller.MoveSpeed.x) > 0.1f || Mathf.Abs(Controller.MoveSpeed.z) > 0.1f)
        {
            timer += Time.deltaTime * SpeedWalkBobbing;
            transform.localPosition = new Vector3(transform.localPosition.x, defaultPosY + Mathf.Sin(timer) * BobbingAmount, transform.localPosition.z);
        }    
    }
}
