using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] AudioClips;
    public float radius = 1f;
    public float minPitch = 0.7f;
    public float maxPitch = 1.20f;
    public float lockedY = 2f;

    private float randomTime;


    // Start is called before the first frame update
    void Start()
    {
      //  audioSource = GetComponent<AudioSource>();
        randomTime = Random.Range(10f, 5f);
        StartCoroutine(AmbiSound());
    }

    // Update is called once per frame
    void Update()
    {
        // AudioClip randomSound = AudioClips[Random.Range(0,AudioClips.Length)];
        // audioSource.PlayOneShot(randomSound);

        
    }

    IEnumerator AmbiSound()
    {
        while (true)
        {
            Debug.Log("SoundPlayed");
            yield return new WaitForSeconds(randomTime);
            int randomIndex = Random.Range(0, AudioClips.Length);
            audioSource.clip = AudioClips[randomIndex];
            audioSource.pitch = Random.Range(minPitch, maxPitch);
            audioSource.Play();
            StartCoroutine(Randomize());
        }
    }


    IEnumerator Randomize()
    {
        while (true)
        {
            Debug.Log("PositionChanged");
            Vector3 randomPosition = Random.insideUnitSphere * radius;
            yield return transform.position = randomPosition;
            StopCoroutine(Randomize());
        }
    }
  




}
