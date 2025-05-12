using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nemico : Creatura
{
    private int _loot;

    public Nemico(int hp, int atk, int def, int loot) : base(hp, atk, def)
    {
        SetLoot(loot);
    }

    public int GetLoot() => _loot;
    
    public void SetLoot(int loot)
    {
        this._loot = Mathf.Max(0, loot);
    }
}
