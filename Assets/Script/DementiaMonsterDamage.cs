using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DementiaMonsterDamage : MonoBehaviour
{ 
    public float dementiaAttack = 5f;
    public float dementiaRate = 1f;
    public float dementiaTimer = 0f;

    private DementiaBar dementiaBar;



    // Start is called before the first frame update
    private void Start()
    {
        dementiaBar = GetComponent<DementiaBar>();
    }

    // Update is called once per frame
   public void Update()
    {
        dementiaTimer += Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (dementiaTimer >= dementiaRate && collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<DementiaBar>().currentDemence += dementiaAttack;
            dementiaTimer = 0f;
        }
    }
}
