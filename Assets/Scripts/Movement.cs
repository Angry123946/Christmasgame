using UnityEngine;

public sealed class Movement : MonoBehaviour
{
    [SerializeField] private float[] heights;
    [SerializeField] private int currentHeight;
    [SerializeField] private float speed;
    [SerializeField] private float speedflying;
    [SerializeField] private Rigidbody2D rb;

    void Update()
    {
        rb.velocity = Vector2.right * speedflying;

        if (Input.GetKeyDown(KeyCode.W) && currentHeight > 0)
        {
            currentHeight--;
        }

        if (Input.GetKeyDown(KeyCode.S) && currentHeight < heights.Length - 1)
        {
            currentHeight++;
        }

        Vector3 position = transform.position;
        position.y = Mathf.Lerp(position.y, heights[currentHeight], Time.deltaTime * speed);
        transform.position = position;
    }
}