using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DementiaMonsterDamage : MonoBehaviour
{ 
    public float dementiaAttack = 5f;
    public float dementiaRate = 1f;
    public float dementiaTimer = 0f;
    public int Health = 2;
    public GameObject Heart1;
    public GameObject Heart2;

    // private DementiaBar dementiaBar;



    // Start is called before the first frame update
    private void Start()
    {
        //dementiaBar = GetComponent<DementiaBar>();
    }

    // Update is called once per frame
    public void Update()
    {
        // dementiaTimer += Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Health <= 2)
            {
                Heart1.SetActive(false);
                Health--;
            }
            else if (Health <= 0) 
                { 
                Heart2.SetActive(false);
                SceneManager.LoadScene("MainMenu");
                }

            //collision.gameObject.GetComponent<DementiaBar>().currentDemence += dementiaAttack;
            //dementiaTimer = 0f;
        }
    }
}
