using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsempioInheritance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Creatura c1 = new Creatura(100, 5, 2);
        //c1.SetHp(100);
        //c1.SetAtk(5);
        //c1.SetDef(2);

        Personaggio p1 = new Personaggio(100, 5, 2, 7);
        //p1.SetHp(100);  
        //p1.SetAtk(5);
        //p1.SetDef(2);
        //p1.SetLvl(1);

        Nemico n1 = new Nemico(40, 6, 1, 500);

        Alleato a1 = new Alleato(100, 3, 5, 7, Alleato.ROLE.TANKER);

        Boss b1 = new Boss(1000, 100, 100, 2000, 100);

        c1.Attack(b1);
        p1.Attack(b1);
        a1.Attack(b1);
        n1.Attack(b1);
        b1.Attack(b1);

        c1.Attack(n1);
        p1.Attack(n1);
        a1.Attack(n1);
        n1.Attack(n1);
        b1.Attack(n1);

        c1.Attack(a1);
        p1.Attack(a1);
        a1.Attack(a1);
        n1.Attack(a1);
        b1.Attack(a1);

        c1.Attack(p1);
        p1.Attack(p1);
        a1.Attack(p1);
        n1.Attack(p1);
        b1.Attack(p1);

        c1.Attack(c1);
        p1.Attack(c1);
        a1.Attack(c1);
        n1.Attack(c1);
        b1.Attack(c1);

        // BINDING DINAMICO
        Creatura c2 = new Creatura(100, 20, 4);
        c2.Attackk(c1);
        Creatura c3 = new Personaggio(100, 20, 4, 7);
        c3.Attackk(c1); // <-- in questo modo usa la funzioen Attack della classe Personaggio perché in Creatura è VIRTUAL mentre in Personaggio è OVERRIDE
        Creatura c4 = new Alleato(100, 20, 4, 7, Alleato.ROLE.ATTACKER);
        c4.Attackk(c1); // <-- in questo modo usa la funzioen Attack della classe Alleato perché in Creatura è VIRTUAL mentre in Alleato è OVERRIDE
        c4.TakeDamage(1); // <-- in questo caso però userà la versione TakeDamage() di Personaggio , perché Alleato non ha un suo OVERRIDE della funzione
    
    }
}
