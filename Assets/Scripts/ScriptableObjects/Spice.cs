using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct Spice
{
    public SpiceType spiceType;
    public int amount;
    public Unit unit;

    public Spice(SpiceType spice, int amount, Unit unit, Sprite image)
    {
        this.spiceType = spice;
        this.amount = amount;
        this.unit = unit;
    }
}
