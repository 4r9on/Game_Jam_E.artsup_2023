using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Texts());

    }

    IEnumerator Texts()
    {
        text1.SetActive(true);
        yield return new WaitForSecondsRealtime(5f);
        text1.SetActive(false);
        text2.SetActive(true);
        yield return new WaitForSecondsRealtime(5f);
        text2.SetActive(false);
    }
}
