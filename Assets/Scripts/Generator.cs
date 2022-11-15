using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;


public class Generator : MonoBehaviour
{
    [SerializeField] GameObject objectdown;
    [SerializeField] GameObject objectbad;
    [SerializeField] private int i=10;
    public int number;
    [SerializeField] private int co_ile_dowac;
    [SerializeField] private Vector3 pos = new Vector3(100,0,0);
    


    public void Gnerate()
    {
        number = UnityEngine.Random.Range(1, 100);
        
        if(number%2 ==0)
        {
            Instantiate(objectdown, transform.position + i * pos, Quaternion.identity);
            i = i + co_ile_dowac;
            Debug.Log("a");
        }
        if (number % 2 == 1)
        {
            Instantiate(objectbad, transform.position + i * pos, Quaternion.identity);
            i = i + co_ile_dowac;
            Debug.Log("b");
        }


        

    }
    
    void Start()
    {
        InvokeRepeating("Gnerate", 0, 0.4f);
    }
    
}
