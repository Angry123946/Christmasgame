using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float speedflying;
    [SerializeField] Rigidbody2D rb;

    void Update()
    {
        rb.velocity= Vector2.right*speedflying;

        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up*speedflying);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * speedflying);
        }

    }
}
