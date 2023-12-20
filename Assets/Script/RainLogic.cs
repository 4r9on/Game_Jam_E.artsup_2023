using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RainLogic : MonoBehaviour
{
    public GameObject Trigger;
    public GameObject TriggerExit;
    public AudioSource RainInside;
    public AudioSource Rain;

    public float Fadetime = 2f;
    bool Inside = false;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static class FadeAudio
    {
        public static IEnumerator FadeOut(AudioSource audioSource, float Fadetime)
        {
            float volume = audioSource.volume;

            while(audioSource.volume > 0)
            {
                audioSource.volume -= volume * Time.deltaTime / Fadetime;

                yield return null;
            }

            audioSource.Stop();
            audioSource.volume = volume;

        }

        public static IEnumerator FadeIn(AudioSource audioSource, float Fadetime)
        {
            float volume = 0.2f;

            audioSource.volume = 0;
            audioSource.Play();
            while (audioSource.volume < 1.0f)
            {
                audioSource.volume += volume * Time.deltaTime / Fadetime;

                yield return null;
            }
            audioSource.volume = 1.00f;
        }
    }
    void OnTriggerStay(Collider Trigger)
    {
        if (Trigger.gameObject.CompareTag("Player"))

        {
            RainInside.UnPause();
            Rain.Pause();
        }
    
    }

    void OnTriggerExit(Collider Trigger)
    {
        if (Trigger.gameObject.CompareTag("Player"))
        {
            Rain.UnPause();
            RainInside.Stop();
        }
    }
}
