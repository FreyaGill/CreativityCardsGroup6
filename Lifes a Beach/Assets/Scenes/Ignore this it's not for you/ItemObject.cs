﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemRarity
{
    Common,
    Rare,
    Epic
}

public abstract class ItemObject : ScriptableObject
{
    public GameObject prefab;
    public ItemRarity type;
    [TextArea(15,20)]
    public string description;
}
