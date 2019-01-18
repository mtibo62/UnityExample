using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {


    public float speed;
    private Rigidbody2D rb;
    // Use this for initialization


    void Start()
    {
        //sr = GetComponent<SpriteRenderer>();
        //animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

   
        //width = GetComponent<Collider2D>().bounds.extents.x + 0.1f;
        //height = GetComponent<Collider2D>().bounds.extents.y + 0.2f;
    }

    // Update is called once per frame
    void FixedUpdate () {
        float horzMove = Input.GetAxisRaw("Horizontal");

        // Need to get Mannys y
        Vector2 vect = rb.velocity;

        // Change x and keep y as is
        rb.velocity = new Vector2(horzMove * speed, vect.y);
    }
}
