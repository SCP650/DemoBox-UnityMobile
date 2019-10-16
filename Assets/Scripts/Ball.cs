using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    public float speed = 100.0f;
    [Tooltip("The Angle Boosted")]
    [SerializeField]
    public float boost = 1f;
    // Update is called once per frame
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   //CITATION: I borrowed the calculation from noobtuts.com
        // Hit the Racket?
        if (collision.gameObject.name == "Slider")
        {
            // Calculate hit Factor
            float x = hitFactor(transform.position,
                              collision.transform.position,
                              collision.collider.bounds.size.x);

            // Calculate direction, set length to 1
            Vector2 dir = new Vector2(x, 1).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

    }
    float hitFactor(Vector2 ballPos, Vector2 racketPos,
                float racketWidth)
    {
        // ascii art:
        //
        // 1  -0.5  0  0.5   1  <- x value
        // ===================  <- racket
        return (ballPos.x - racketPos.x) * boost / (racketWidth);
    }
}

