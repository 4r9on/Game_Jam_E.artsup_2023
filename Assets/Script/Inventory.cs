using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private InventoryDisplay display;
    private InventoryData data;

    private void Awake()
    {
        

        data = new InventoryData();
    }
}
