using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3 : MonoBehaviour
{
    // 2 modi per esporre una variabile nell'inspector:
    // usare public prima della creazione della variabile
    public int num1 = 10;
    
    // usare [SerializeField] che si applica sia a private che non
    //[SerializeField]
    //int num2 = 5;
    //[SerializeField]
    //private int num3 = 15;

    public int num4 = 20;

    public int es5 = 100;

    public int partenza = 0;

    public int a = 20;
    public int b = 5;

    //float time = 0;

    [Range(0,10)] // mette uno slider range nell'interfaccia
    public int voto = 10;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello World!");
        //Debug.Log("somma: " + (num1 + num2 + num3 + num4));
        //Debug.Log("prodotto: " + (num1 * num2 * num3 * num4));
        //Debug.Log("media: " + (num1 + num2 + num3 + num4)/(4));
        //if (es5 % 2 == 0)
        //{
        //    Debug.Log("il numero è pari");
        //}
        //else
        //{
        //    Debug.Log("il numero è dispari");
        //}
        //if (es5 > 10)
        //{
        //    Debug.Log("il numero è maggiore di 10");
        //}
        //else
        //{
        //    Debug.Log("il numero è minore di 10");
        //}
        //Stampa2Successivi();
        //Stampa2Precedenti();
        //MaggioreTra2();
        //MinoreTra2(a, b);
        VotoStudente();
    }

    void Stampa2Successivi()
    {
        //int partenza = 0;

        Debug.Log(partenza.ToString() + " " + (partenza + 1).ToString() + " " + (partenza + 2).ToString());
    }

    void Stampa2Precedenti()
    {
        Debug.Log(partenza.ToString() + " " + (partenza - 1).ToString() + " " + (partenza - 2).ToString());
    }

    void MaggioreTra2()
    {
        if (a > b)
            Debug.Log("il numero maggiore tra " + a + " e " + b + " è " + a);
        else
           Debug.Log("il numero maggiore tra " + a + " e " + b + " è " + b);
    }

    void MinoreTra2(int a, int b)
    {
        if (a < b)
        {
            Debug.Log("il numero minore tra " + a + " e " + b + " è " + a);
        }
        else
        {
           Debug.Log("il numero minore tra " + a + " e " + b + " è " + b);
        }
    }

    void VotoStudente()
    {
        if (voto >= 10)
            Debug.Log("A+");
        else if (voto >= 9)
            Debug.Log("A");
        else if (voto >= 7) // si poteva anche scrivere così: (voto >= 7 && voto <= 8)
            Debug.Log("B");
        else if (voto >= 6)
            Debug.Log("C");
        else if (voto >= 5)
            Debug.Log("E");
        else if (voto >= 0)
            Debug.Log("F");
        else
            Debug.Log("voto non valido");

        // altra opzione è con lo switch statement

        //switch (voto)
        //{
        //    case >= 10:
        //        Debug.Log("A+");
        //        break;
        //    case >= 9:
        //        Debug.Log("A");
        //        break;
        //    case >= 7:
        //        Debug.Log("B");
        //        break;
        //    case >= 6:
        //        Debug.Log("C");
        //        break;
        //    case >= 5:
        //        Debug.Log("D");
        //        break;
        //    case >= 0:
        //        Debug.Log("F");
        //        break;
        //    default:
        //        Debug.Log("voto non valido");
        //        break;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello World!"); in questo modo lo stampa per ogni frame quindi minimo 60 perché si usano 60 FPS

        //time += Time.deltaTime;
        //if (time < 30)
        //    Debug.Log("sono trascorsi meno di 30 secondi");
        //else if (time > 60)
        //    Debug.Log("è trascorso più di un minuto");
        //else if (time > 45)
        //    Debug.Log("sono trascorsi più di 45 secondi");
        //else if (time > 30)
        //    Debug.Log("sono trascorsi più di 30 secondi");

        //Debug.Log("time: " + time);

    }
}
