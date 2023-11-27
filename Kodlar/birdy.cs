using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdy : MonoBehaviour
{
    public float velocity = 1f;
    public Rigidbody2D rb2d;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = Vector2.up * velocity;

        }
    }
}
