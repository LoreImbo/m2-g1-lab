using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creatura
{
    protected int _hp; // utilizziamo una nuova keyword PROTECTED al posto di private --> in questo modo le classe che ereditano possono avere accesso alla variabile
    protected int _atk;
    protected int _def;

    // costruttore
    public Creatura(int hp, int atk, int def)
    {
       //_hp = hp;
       //_atk = atk;
       //_def = def;
       SetHp(hp);
       SetAtk(atk);
       SetDef(def);
    }

    public void Attack(Creatura target) // questa è la soluzione, senza dover ripetere per tutte le classi; si perde di specificità perché all'interno posso usare solo le variabili e metodi di Creatura
    {
        int damage = Mathf.Max(0, _atk - target.GetDef());
        //target.SetHp(target.GetHp() - damage);
        target.AddHp(-damage);


        // NON è' PERO MOLTO CONSIGLIATO PERCHE' STO LEGANDO A CREATURA UNA SOTTOCLASSE E SE CAMBIA QUALCOSA A LOGICA DI SOTTOCLASSI DEVO MODIFICARE CLASSE MADRE --> NON VA BENE, DEVE ESSERE IL CONTRARIO
        if (target is Personaggio) // is permette di valutare il type di una classe
        //if (target is Personaggio p) // --> anche questo fa CAST, solo se IF è true
        {
            //float f = 105.25f; 
            //int n = (int)f; --> questo è il CAST

            Personaggio p = (Personaggio)target; // sto facendo il CAST di target --> così target non è più Creatura ma è Personaggio e quindi posso applicare metodi della classe Personaggio;
            p.LevelUp();
            //Personaggio p = target as Personaggio // --> CAST
        }
    }

    public virtual void TakeDamage(int damage)
    {
        damage -= _def;
        if (damage > 0)
        {
            AddHp(-damage);
        }
    }

    // e quindi la funzione sopra cambia
    public virtual void Attackk(Creatura target) // in questo modo ho separato chi fa danno da chi prende il danno
    {
        target.TakeDamage(_atk);
    }

    public int GetHp() => _hp;
    public int GetAtk() => _atk;
    public int GetDef() => _def;

    public void AddHp(int amount) => SetHp(_hp + amount);

    public void SetHp(int hp)
    {
        this._hp = Mathf.Max(0, hp);
    }

    public void SetAtk(int atk)
    {
        this._atk = Mathf.Max(1, atk);
    }

    public void SetDef(int def)
    {
        this._def = Mathf.Max(1, def);
    }

}
