using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepasoFor : MonoBehaviour
{

    public int num1;
    public int num2;


    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0; i<5; i++)
        //{
        //    Debug.Log(i);
        //}

        //multiplos de 2 hasta el cuarenta inclusive 
        //for (int i=2; i<= 40; i+=2)
        //{
        //    Debug.Log(i);
        //}

        //multiplos de un entero ingresado por inspector hasta otro número ingresado por inspector NO inclusive
        //for (int i = num1; i < num2; i+= num1)
        //{
        //    debug.log(i);
        //}

        //escribir en consola de manera descendente los numeros enteros entre 100 y 10 inclusive (excepto el 33)
        for (int i=100; i >= 10; i--)
        {
            if (i == 33)
            {
                continue;  //saltea ese numero
            }
            Debug.Log(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
