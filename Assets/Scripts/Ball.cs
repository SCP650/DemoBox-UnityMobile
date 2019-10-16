using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    public float speed = 100.0f;
    // Update is called once per frame
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }
}

