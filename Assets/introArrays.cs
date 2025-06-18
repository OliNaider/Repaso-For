using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introArrays : MonoBehaviour
{
    public int[] edades;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(edades[0]); //primer elemento del array
        Debug.Log("el array tiene " + edades.Length + " elementos"); //cuantos elementos tiene el array
        Debug.Log(edades[edades.Length - 1]);  //ultimo elemento del array


        //escribir todos los elementos del array
        for (int i = 0; i < edades.Length; i++)
        {
            Debug.Log(edades[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
