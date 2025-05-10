using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    public int numeroMax;
    List<int> list_int = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        List<int> lista_int = GeneraLista(numeroMax);
    }

    public List<int> GeneraLista(int numeroMax)
    {
        List<int> list_int = new List<int>(numeroMax);
        for (int i = 0; i < numeroMax; i++)
            {
                if ((i + 1) % 3 == 1)
                {
                    Debug.Log("posizione iniziale");
                    list_int.Insert(0,i);
                    foreach (int el in list_int)
                        Debug.Log($"Contenuto lista: {el}");
                }
                else if ((i + 1) % 3 == 2)
                {
                    Debug.Log("posizione finale");
                    list_int.Add(i);
                    foreach (int el in list_int)
                        Debug.Log($"Contenuto lista: {el}");
                }
                else
                {
                    Debug.Log("posizione intermedia");
                    list_int.Insert(list_int.Count / 2,i);
                    foreach (int el in list_int)
                        Debug.Log($"Contenuto lista: {el}");
                }
            }
        return list_int;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
