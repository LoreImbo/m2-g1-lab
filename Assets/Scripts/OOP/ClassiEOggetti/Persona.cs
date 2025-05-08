

using Unity.VisualScripting;
using UnityEngine; // ci serve ad esempio per il Debug.Log()
//using System.Diagnostics;

[System.Serializable] // attributo che rende la classe SERIALIZZABILE --> ovvero salvabile su file, quindi ad esempio salvabile in scena e quindi visibile dall'INSPECTOR
// --> dopodiche va aggiunto nel file il comando public Persona nomeclasse
public class Persona // senza : MonoBehaviour impedisce di aggiungerlo a un GameObject su Unity --> infatti senza quello NON si crea una COMPONENTE
{
    // PROPERTY
    public float Peso { get; set; } // proprietà va scritta con la lettera maiuscola
    // ora posso fare p1.Peso = 70; --> e non ho bisogno di scrivere il set e il get, perché lo fa in automatico
    // se invece la definisco come private, non posso accedere al set e quindi non posso modificarla dall'esterno
    public float Altezza { get; private set; } // in questo modo posso accedere al get, ma non al set --> quindi non posso modificarla dall'esterno, ma solo visualizzarla
   
    public float altezza;
    public string occhi;
    public string nome; // senza il public, io non posso vedere questi attributi nell'altro file e non ci posso agire
    
    // TECNICA DI INCAPSULAMENTO --> metodo che restituisce valore variabile (GetEta) e metodo che cambia valore facendo controlli (SetEta)
    public int eta; // se la trasformo in private, di modo che non possa essere modificata, si può definire un metodo che restituisce l'età
    // si può anche usare [SerializeField] private int eta --> però dall'inspector non ho controllo sul valore che si inserisce --> è buona prassi fare così perché rende codice più robusto
    //private int eta;
    public int GetEta()
    {
        return eta;
    }
    // si può fare anche la forma lambda; più compatta e veloce
    // si può fare anche per il SET
    public int GetEtaa() => eta;
    // se invece voglio modificarla si può fare così
    public void SetEta(int nuovaEta) // in questo modo si possono inserire dei controlli sull'eta
    {   // nell'altro file posso cambiare l'eta richiamando questo metodo
        if (nuovaEta >= 0)
            eta = nuovaEta;
        else
            eta = 0; // oppure stampo messaggio di errore
            Debug.LogError($"Il valore di {nuovaEta} non è ammissibile");
    }
    // si può sintetizzare questa funzione in questo modo --> operatore ternario (elvis)
    public void SetEtaaa(int eta)
    {           // (condizione) ? caso true : caso false ;
        this.eta = (eta >= 0)   ?    eta    :     0;
        // altro modo
        this.eta = Mathf.Max(0, eta);
    } 
    // quindi ora facciamo forma lambda
    public void SetEtaaaa(int eta) => this.eta = (eta > 0) ? eta : 0;
    // altro modo per dire la stessa funzione
    public void SetEtaaaaa(int eta) => this.eta = Mathf.Max(0, eta);
    // SI UTILIZZA IL this. PER RICHIAMARE UNA VARIABILE PRIVATA DEFINITA FUORI DALLA FUNZIONE
    // p1.setEtaa(30); --> this è l'oggetto puntato da p1
    public void SetEtaa(int eta) // in questo modo si possono inserire dei controlli sull'eta
    {   // nell'altro file posso cambiare l'eta richiamando questo metodo
        if (eta >= 0)
            this.eta = eta;
        else
            this.eta = 0; // oppure stampo messaggio di errore
            Debug.LogError($"Il valore di {eta} non è ammissibile");
    }

    public void SetNome(string nome) // in questo modo si possono inserire dei controlli sull'eta
    {   // nell'altro file posso cambiare l'eta richiamando questo metodo
        if (!string.IsNullOrEmpty(nome))
            this.nome = nome;
        else
            Debug.LogError($"Il valore di {nome} non è ammissibile"); // correggo il messaggio di errore
    }

    public void SetAltezza(float altezza) // aggiunta del metodo SetAltezza
    {
        if (altezza > 0)
            this.altezza = altezza;
        else
            Debug.LogError($"Il valore di {altezza} non è ammissibile"); // messaggio di errore per altezza non valida
    }

    public void SetOcchi(string occhi) // aggiunta del metodo SetOcchi
    {
        if (!string.IsNullOrEmpty(occhi))
            this.occhi = occhi;
        else
            Debug.LogError($"Il valore di {occhi} non è ammissibile"); // messaggio di errore per occhi non validi
    }

    // alcune regole sul confronto tra operatori
    // invece che usare il not per flippare l'operatore, si può inserire il ! all'inizio --> if (!string.IsNullOrEmpty(nome)) --> equivale a mettere il == false

    public static int EtaScuolaDellObbligo = 16; // la keyword "static" evidenzia una variabile statica
    public static int EtaPensionabile = 99;

    public bool IsMaggiorenne()
    {
        return eta >= 18;
    }

    public int QuantoMancaAllaPensione()
    {
        return Persona.EtaPensionabile - eta; // si può anche scrivere senza Persona. visto che siamo dentro la classe Persona
    }

    public void Presentati()
    {
        //Debug.Log("Ciao, mi chiamo " + nome + " e ho " + eta + " anni.");
        Debug.Log($"Ciao, mi chiamo {nome} e ho {eta} anni."); // tipo fstring per python
    }

    // COSTRUTTORI
    // costruttore senza parametri
    public Persona()
    {
        // SE QUA NON METTO NULLA, IL COSTRUTTORE USERA' I VALORI DI DEFAULT INSERITI QUANDO CREATE LE VARIABILI
        nome = "Anonimo";
        eta = 1;
        altezza = 0.3f;
        occhi = "Forse";
    }

    // costruttore con parametri
    public Persona(string nome, int eta, float altezza, string occhi)
    {
        // in questo modo setta le variabili usando i parametri; però non sto facendo i controlli che invece avevo definito all'intero dei SET()
        this.nome = nome;
        this.eta = eta;
        this.altezza = altezza;
        this.occhi = occhi;

        // allora posso fare così
        SetNome(nome);
        SetEta(eta);
        SetAltezza(altezza);
        SetOcchi(occhi);
    }

    // adesso per costruire una persona posso fare -->
    // Persona p5 = new Persona("gandalf", 60, 1.8f, "due)

    // ALTRO ESEMPIO DI COSTRUTTORE
    // questo costruttore PRIMA di eseguire il codice nelle sue graffe, esegue il codice riportato
    // nel costruttore che ha i parametri (nome, eta, altezza, occhi), ovvero quello qua sopra
    // questo è dovuto alla dicitura : this (parametri)
    public Persona(string nome, int eta) : this (nome, eta, 0.3f, "due")
    {
        Debug.Log("Costruttore con 2 parametri");
    }

    


}