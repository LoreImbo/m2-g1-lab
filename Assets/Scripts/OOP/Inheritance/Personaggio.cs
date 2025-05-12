using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaggio : Creatura
{
    private int _lvl;

    // costruttore 
    public Personaggio(int hp, int atk, int def, int lvl) : base(hp, atk, def) // --> lui in automatico fa questo, ovvero che costruttore Personaggio richiama costruttore classe Base (madre)
    {
        SetLvl(lvl);
    }

    public override void Attackk(Creatura target)
    {
        //base.Attack(target); // <-- richiama la versione di Attack() scritta nella classe madre
        target.TakeDamage(_atk + _lvl / 2);
    }

    // IN QUESTO MODO SFRUTTO FUNZIONI DELLA CLASSE MADRE MA LE MODIFICO O AGGIUNGO COMPONENTI SPECIFICHE DELLA CLASSE FIGLIA

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage); // <-- richiama la versione di TakeDamage(int) di Creatura
        LevelUp(); // <-- e poi fa level up
    }

    public int GetLvl(int lvl) => lvl;
    
    public void SetLvl(int lvl)
    {
        this._lvl = Mathf.Max(0, lvl);
    }

    public void LevelUp()
    {
        _lvl++;
        //SetHp(GetHp() + 5);  // --> soluzione se le variabili sono private
        _hp += 10; // --> posso scriverle così perché ho inserito il termine PROTECTED nelle variabili
        _atk += 5;
        _def += 5;

    }
}
