using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4 : MonoBehaviour
{
    // ES 1
    int index = 10;
    int num = 0;

    // ES 2
    int [] arr = new int [4];
    int somma = 0;
    int prodotto = 1;

    // ES 3
    public int numero = 15;

    // ES 4
    public int start = 5;
    public int amount = 3;

    // ES 5
    public int find = 0;
    int [] new_arr = new int [5];
    
    // Start is called before the first frame update
    void Start()
    {
        // ES 1
        //while (index > 0)
        //{
        //    Debug.Log("index: " + index);
        //    Debug.Log("num: " + num);
        //    num++;
        //    index--;
        //}

        // ES 2
        //for (int i = 0; i < arr.Length; i++)
        //{   
        //    if (i >= 2)
        //        break;
        //    arr[i] = Random.Range(0,11);
        //    Debug.Log("posizione arr: " + i + "; valore arr: " + arr[i]);
        //    somma += arr[i];
        //    Debug.Log("somma: " + somma);
        //    prodotto *= arr[i];
        //    Debug.Log("prodotto: " + prodotto);
        //}

        // ES 3
        //for (int i = 1; i < 31; i++)
        //{
        //    if (i % 3 == 0 && i % 5 == 0) // se metti numero al posto di i, allora è come chiede l'esercizio
        //    {
        //        Debug.Log("FizzBuzz");
        //    }
        //    else if (i % 3 == 0)
        //    {
        //        Debug.Log("Fizz");
        //    }
        //    else if (i % 5 == 0)
        //    {
        //        Debug.Log("Buzz");
        //    }
        //    else
        //    {
        //        Debug.Log(i);
        //    }
        //}

        // ES 4
        //for (int i = 0; i <= amount; i++)
        //{
        //    Debug.Log(start + i);
        //}

        // ES 5
        //for (int i = 0; i < new_arr.Length; i++)
        //{
        //    new_arr[i] = Random.Range(0,11);
        //    if (new_arr[i] == find)
        //    {
        //        Debug.Log("found: " + find);
        //    }
        //    else
        //        Debug.Log("not found");
        //}
        //Debug.Log("iterations finisched");

        // ES 6
        int [] array_prova = GeneraArray();
        //Debug.Log(array_prova[1]);
        //Debug.Log(array_prova[10]);
        //Debug.Log(array_prova[18]);

        int somma = SommaArray(array_prova);
        Debug.Log(somma);

        StampaArray(array_prova);

        // ES 7
        int [] arr_new = GeneraArray2(arr: array_prova, min: 100, max: 201);
        Debug.Log(SommaArray(arr_new));
        StampaArray(arr_new);
    }

    int [] GeneraArray()
    {
        int [] arr = new int [20];
        for (int i = 0; i < arr.Length; i++)
            arr[i] = Random.Range(0,101);
        return arr;
    }

    int SommaArray(int [] arr)
    {
        int somma = 0;
        for (int i = 0; i < arr.Length; i++)
            somma += arr[i];
        return somma;
    }

    void StampaArray(int [] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Debug.Log("posizione: " + i + "; valore: " + arr[i]);
    }

    int [] GeneraArray2(int [] arr, int min, int max)
    {
        for (int i = 0; i < arr.Length; i++)
            arr[i] = Random.Range(min,max);
        return arr;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
