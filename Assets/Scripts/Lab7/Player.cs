using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string nome;
    private int punteggio;
    private int danno;

    public void IncrementaPunteggio(int incremento)
    {
        punteggio += incremento; // si potrebbe anche scrivere this.punteggio
    }

    public int GetPunteggio() => punteggio;

    public void SetPunteggio(int punteggio)
    {
        this.punteggio = (punteggio >= 0)   ?    punteggio    :     0;
        // altro modo --> this.eta = Mathf.Max(0, eta);
    }

    public bool IsVincitore()
    {   
        if (punteggio >=  100) // si potrebbe anche scrivere this.punteggio
            return true;
        return false;
    }

    public int GetDanno() => danno;

    public void SetDanno(int danno) => this.danno = (danno > 0) ? danno : 0;
}
