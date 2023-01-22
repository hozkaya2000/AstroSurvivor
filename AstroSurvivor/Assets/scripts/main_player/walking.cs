using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour

{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = (mousePos - transform.position).normalized;

            rb.velocity = Vector2.zero;
            rb.AddForce(direction * moveSpeed, ForceMode2D.Impulse);
        }
        if (Input.GetMouseButtonUp(1))
        {
            rb.velocity = Vector2.zero;
        }
    }

}