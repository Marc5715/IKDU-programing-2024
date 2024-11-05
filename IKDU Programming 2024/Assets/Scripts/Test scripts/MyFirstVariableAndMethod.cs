using System.Collections;
using System.Collections.Generic;
using System.IO;
using JetBrains.Annotations;
using UnityEngine;

public class MyFirstVariableAndMethod : MonoBehaviour
{

    public int a = 512;
    public int b = 731;
    int d0= 10;
    int d1= 20;

    public float a1 = 23.4f;
    public float b1 = 222.3f;

    

    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("My initial values are a={0}, b={1}", a, b);
        (a, b) = SwapInt(a,b);
        Debug.LogFormat("My ending values are a={0}, b={1}", a, b);


        Debug.LogFormat("d0={0}, d1={1}", d0, d1);
        (d0,d1) = SwapInt(d0,d1);
        Debug.LogFormat("d0={0}, d1={1}", d0, d1);


        Debug.LogFormat("a1={0}, b1={1}",a1,b1);
        (a1,b1) = SwapFloat(a1,b1);
        Debug.LogFormat("a1={0}, b1={1}",a1,b1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    ///Swaps two intergers.
    /// </summary>
    (int, int) SwapInt (int m, int n)
        {
            int temp = m;
            m =n;
            n = temp;

            return (m,n);
        }


        /// <summary>
        /// Swaps two floats
        /// </summary>
     (float, float) SwapFloat (float f, float g)
        {
            float temp = f;
            f = g;
            f = temp;

            return (f,g);
        }
}
