using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStep : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip wool;
    public AudioClip wood;
    public AudioClip grass;

    RaycastHit hit;
    public Transform RayStart;
    public float range;
    public LayerMask layerMask;

    public void FootSteps()
    {
        if (Physics.Raycast(RayStart.position, RayStart.transform.up * -1, out hit, range, layerMask)) ;
        {
            if (hit.collider.CompareTag("wool"))
            {
                PlayFootStepSound(wool);
            }
            if (hit.collider.CompareTag("wood"))
            {
                PlayFootStepSound(wood);
            }
            if (hit.collider.CompareTag("grass"))
            {
                PlayFootStepSound(grass);
            }
        }
    }

    void PlayFootStepSound(AudioClip audio)
    {   
        AudioSource.pitch = Random.Range(0.7f, 1f);
        AudioSource.PlayOneShot(audio);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.DrawRay(RayStart.position, RayStart.transform.up * range, Color.yellow);
    }
}
