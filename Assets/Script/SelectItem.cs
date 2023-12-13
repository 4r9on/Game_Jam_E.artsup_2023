using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectItem : MonoBehaviour, IPickable
{
    
    public ItemSO itemScriprableObject;

    public void PickItem()
    {
        Destroy(gameObject);
    }
}

