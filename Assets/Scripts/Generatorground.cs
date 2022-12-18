using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generatorground : MonoBehaviour
{
    [SerializeField] GameObject objectdown;
    [SerializeField] private int i = 10;
    [SerializeField] private int co_ile_dowac;
    [SerializeField] private Vector3 pos = new Vector3(100, 0, 0);

    public void Gnerate()
    {
        Instantiate(objectdown, transform.position + i * pos, Quaternion.identity);
        i = i + co_ile_dowac;
        Debug.Log("a");

    }
    void Start()
    {
        InvokeRepeating("Gnerate", 0, 0.4f);
    }
}