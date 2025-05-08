using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct SkillPoints
{
    public int strenght;
    public int dexterity;
    public int mind;

    public int GetPowerLevel()
    {
        return (strenght + dexterity + mind) / 3;
    }

    public SkillPoints(int strenght, int dexterity, int mind) // non si può creare un COSTRUTTORE STRUCT senza valore alle variabili, a differenza delle classi
    {
        this.strenght = strenght;
        this.dexterity = dexterity;
        this.mind = mind;
    }

}