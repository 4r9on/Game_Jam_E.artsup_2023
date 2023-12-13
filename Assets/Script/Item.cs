using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Items", menuName = "ScriptableObjects/Item")]
public class Item : ScriptableObject
{
    public string name;
    public int numberHand;
    public Transform pos;
}
