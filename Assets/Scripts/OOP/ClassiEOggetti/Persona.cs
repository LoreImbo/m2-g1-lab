

using UnityEngine; // ci serve ad esempio per il Debug.Log()
//using System.Diagnostics;

[System.Serializable] // attributo che rende la classe SERIALIZZABILE --> ovvero salvabile su file, quindi ad esempio salvabile in scena e quindi visibile dall'INSPECTOR
// --> dopodiche va aggiunto nel file il comando public Persona nomeclasse
public class Persona // senza : MonoBehaviour impedisce di aggiungerlo a un GameObject su Unity --> infatti senza quello NON si crea una COMPONENTE
{
    public string nome; // senza il public, io non posso vedere questi attributi nell'altro file e non ci posso agire
    
    // TECNICA DI INCAPSULAMENTO --> metodo che restituisce valore variabile (GetEta) e metodo che cambia valore facendo controlli (SetEta)
    public int eta; // se la trasformo in private, di modo che non possa essere modificata, si può definire un metodo che restituisce l'età
    // si può anche usare [SerializeField] private int eta --> però dall'inspector non ho controllo sul valore che si inserisce --> è buona prassi fare così perché rende codice più robusto
    //private int eta;
    //public int GetEta()
    //{
    //    return eta;
    //}
    // se invece voglio modificarla si può fare così
    public void SetEta(int nuovaEta) // in questo modo si possono inserire dei controlli sull'eta
    {   // nell'altro file posso cambiare l'eta richiamando questo metodo
        if (nuovaEta >= 0)
            eta = nuovaEta;
        else
            eta = 0; // oppure stampo messaggio di errore
            Debug.LogError($"Il valore di {nuovaEta} non è ammissibile");
    }

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
}