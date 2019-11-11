using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Default Object", menuName = "Inventory System/Items/Common")]

public class CommonObject : ItemObject
{
    public void Awake()
    {
        type = ItemRarity.Common;
    }
}
