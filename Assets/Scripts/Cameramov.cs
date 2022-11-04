using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramov : MonoBehaviour
{
    [SerializeField] GameObject main;
    [SerializeField] Vector3 targetPos;
    public float moveSpeed;

    void FixedUpdate()
    {
        targetPos = new Vector3(main.transform.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }
}
