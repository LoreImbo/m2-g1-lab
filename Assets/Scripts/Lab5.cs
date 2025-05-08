using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab5 : MonoBehaviour
{
    public int number;
    public int Base;
    public int multiple;
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
