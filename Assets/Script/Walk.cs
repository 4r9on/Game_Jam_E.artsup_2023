using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public List<AudioClip> audio;
    public float time;

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time == 7.0f)
        {
            Debug.Log("sound");
            playSound();

        }
        time = 0f;

    }

    void playSound()
    {
        AudioClip clip = audio[UnityEngine.Random.Range(0, audio.Count)];
        audioSource.PlayOneShot(clip);
    }
}
