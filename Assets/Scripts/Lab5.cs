using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab5 : MonoBehaviour
{
    public int number;
    public int Base = 1;
    public int multiple;
    public int dim;
    public int min;
    public int max;
    public int dim_new_array;
    // Start is called before the first frame update
    void Start()
    {
        if (IsEven(number))
            Debug.Log($"Il numero {number} è pari");
        else
            Debug.Log($"Il numero {number} è dispari");

        if (IsMultipleOf(Base, multiple))
            Debug.Log($"Il numero {multiple} è multiplo del numero {Base}");
        else
            Debug.Log($"Il numero {multiple} non è multiplo del numero {Base}");

        int [] array = GeneraArray(dim, min, max);
        StampaArray(array);
        int min_array = TrovaMinimo(array);
        int max_array = TrovaMassimo(array);
        Debug.Log($"Il valore minimo dell'array è {min_array}, mentre il valore massimo è {max_array}");
        TrovaMinimi2(array);
        TrovaMassimi2(array);
        int [] new_array = CambiaDimensioneArray(array, dim_new_array);
        StampaArray(new_array);
    }

    public bool IsEven(int number)
    {
        if (number % 2 == 0)
            return true;
        return false;
    }

    public bool IsMultipleOf(int Base, int multiple)
    {
        if (multiple % Base == 0)
            return true;
        return false;
    }

    public int [] GeneraArray(int dim, int min, int max)
    {
        int [] arr = new int [dim];
        for (int i = 0; i < dim; i++)
            arr[i] = Random.Range(min,max);
        return arr;
    }

    public void StampaArray(int [] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Debug.Log("posizione: " + i + "; valore: " + arr[i]);
    }

    public int TrovaMinimo(int [] arr)
    {
        int min_value = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] < min_value)
                min_value = arr[i];
        return min_value;
    }

    public int TrovaMassimo(int [] arr)
    {
        int max_value = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] > max_value)
                max_value = arr[i];
        return max_value;
    }

    public void TrovaMinimi2(int [] arr)
    {   
        int min_value1 = int.MaxValue;
        int min_value2 = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] < min_value1 || arr[i] < min_value2)
                if (min_value1 <= min_value2)
                    min_value2 = arr[i];
                else
                    min_value1 = arr[i];
        Debug.Log($"I valori più bassi dell'array sono {Mathf.Min(min_value1,min_value2)} e {Mathf.Max(min_value1,min_value2)}");
    }

    public void TrovaMassimi2(int [] arr)
    {   
        int max_value1 = int.MinValue;
        int max_value2 = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] > max_value1 || arr[i] > max_value2)
                if (max_value1 >= max_value2)
                    max_value2 = arr[i];
                else
                    max_value1 = arr[i];
        Debug.Log($"I valori più alti dell'array sono {Mathf.Max(max_value1,max_value2)} e {Mathf.Min(max_value1,max_value2)}");
    }

    public int [] CambiaDimensioneArray(int [] arr, int dim)
    {
        if (dim < arr.Length)
        {
            int [] new_arr = new int [dim];
            for (int i = 0; i < new_arr.Length; i++)
                new_arr[i] = arr[i];
            return new_arr;
        }
        else if (dim > arr.Length)
        {
            int [] new_arr = new int [dim];
            for (int i = 0; i < arr.Length; i++)
                new_arr[i] = arr[i];
            return new_arr;
        }
        return arr;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
