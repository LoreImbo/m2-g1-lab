using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Nemico
{
    private int _minions;

    public Boss(int hp, int atk, int def, int loot, int minions) : base(hp, atk, def, loot)
    {
        SetMinions(minions);
    }

    public int GetMinions() => _minions;
    public void SetMinions(int minions)
    {
        _minions = Mathf.Max(0, minions);
    }
}
