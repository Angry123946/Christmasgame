using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdspawner : MonoBehaviour
{
    [SerializeField] GameObject bird;
    [SerializeField] private int i = 10;
    [SerializeField] private int co_ile_dowac;
    [SerializeField] private Vector3 pos = new Vector3(100, 0, 0);

    public void Gnerate()
    {
        Instantiate(bird, transform.position + i * pos*i, Quaternion.identity);
        i = i + co_ile_dowac;
        Debug.Log("a");

    }
    void Start()
    {
        InvokeRepeating("Gnerate", 0, 0.4f);
    }
    private void Awake()
    {
        pos = new Vector3(100,  Random.Range(1, 10), 0);
    }
}
