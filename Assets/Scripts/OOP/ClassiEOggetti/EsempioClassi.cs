using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsempioClassi : MonoBehaviour
{
    public Persona personaEsposta;
    // Start is called before the first frame update
    void Start()
    {
        Persona p1; // dichiara una variabile RIFERIMENTO di tipo Persona, ma non ancora creata
        p1 = new Persona(); // crea un oggetto di tipo Persona e lo assegna alla variabile p1
        //Persona p1 = new Persona(); // dichiara e crea un oggetto di tipo Persona in un'unica riga
        p1.nome = "Ajeje";
        p1.eta = 38;
        p1.SetEta(38); // se Persona.eta è una variabile private, in questo modo posso cambiare il suo valore ma utilizzando dei controlli su di essa

        Persona p2 = new()
        {
            nome = "Gervasoni", // assegna il nome "Gervasoni" alla variabile p2
            eta = 34 // assegna l'età 34 alla variabile p2
        }; // dichiara e crea un oggetto di tipo Persona in un'unica riga

        p1.Presentati();
        p2.Presentati();
        p1.Peso = 70; // assegna il peso 70 alla variabile p1

        personaEsposta.Presentati(); // i valori degli attributi vanno inseriti tramite INSPECTOR

        // Posso accedere a una variabile statica e anche assegnare il suo valore --> esso sarà uguale per tutte le istanze della classe
        Persona.EtaScuolaDellObbligo = 18;
        Debug.Log(Persona.EtaScuolaDellObbligo);

        int numero1 = Mathf.RoundToInt(9.8f); // essendo una variabile statica, si può assegnare a una variabile senza dover istanziare un oggetto della classe
        int numero2 = (int)9.8f;
        // il primo arrotonda a 10; il secondo casta a 9
        Debug.Log($"Il valore di num1 è {numero1} e quello di num2 è {numero2}");

        Debug.Log("p1 è maggiorenne? " + p1.IsMaggiorenne());
        int anniAllaPensione = p2.QuantoMancaAllaPensione();
        Debug.Log("a p2 mancano " + anniAllaPensione + " alla pensione");
    }
}
