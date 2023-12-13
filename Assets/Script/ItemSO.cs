using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]
public class ItemSO : MonoBehaviour
{
    [Header("Properties")]
    public float cooldown;
    public itemType item_type;
    public Sprite item_sprite;
}

public enum itemType { Hammer, Machete, Mace, Club };

