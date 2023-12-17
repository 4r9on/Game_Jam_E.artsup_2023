    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class DementiaBar : MonoBehaviour
    {
        public DementiaMonsterDamage DementiaAttack;
        public float maxDemence = 100f;
        public float currentDemence;
        public float DementiaAddition = -0.4f;

        public Image DementiaHealth;
        public Color DementiaLowHealth = new Color(1f, 0f, 0f, 1f);
        public Color OriginalDementiaColor;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            currentDemence -= DementiaAddition * Time.deltaTime;

            currentDemence = Mathf.Max(currentDemence, 0f);

            DementiaHealth.fillAmount = currentDemence / maxDemence;

            if (currentDemence > 80f)
            {
                DementiaHealth.color = DementiaLowHealth;
            }
            else
            {
                DementiaHealth.color = OriginalDementiaColor;
            }
            
            void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player")) ;
            {
                DementiaBar currentDementia = collision.gameObject.GetComponent<DementiaBar>();
                if (currentDementia != null)
                {
                    //currentDementia.ApplyDamage(DementiaAttackDamage);
                }

            }
         
        
        
        }
    }
