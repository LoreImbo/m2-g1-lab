using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alleato : Personaggio
{
    public enum ROLE
    {
        TANKER,
        HEALER,
        SUPPORT,
        ATTACKER
    }

    public Alleato(int hp, int atk, int def, int lvl, ROLE role) : base(hp, atk, def, lvl)
    {
        SetRole(role);
    }
    private ROLE _role;

    public ROLE GetRole() => _role;
    public void SetRole(ROLE role)
    {
        _role = role;
    }
}
