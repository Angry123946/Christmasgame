using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdspawner : MonoBehaviour
{
    [SerializeField] GameObject bird;

    [SerializeField] private int i = 10;

    [SerializeField] private int co_ile_dowac;
    [SerializeField] private Vector3 pos;

    public void Gnerate()
    {


        Instantiate(bird, transform.position + i * pos, Quaternion.identity);
        i = i + co_ile_dowac;
        Debug.Log("a");

    }
    void Start()
    {
        pos = new Vector3(100, 0, Random.Range(1, 10));
        InvokeRepeating("Gnerate", 0, 0.4f);
    }
}
