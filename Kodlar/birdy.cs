using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class birdy : MonoBehaviour
{
    public bool isDead;

    public float velocity = 1f;
    public Rigidbody2D rb2d;
    public GameManager managerGame;
    public GameObject DeathScrenn;

    private void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = Vector2.up * velocity;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreArea")
        {
            managerGame.UptadeScore();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "deatharea")
        {
            isDead = true;
            Time.timeScale = 0;
            DeathScrenn.SetActive(true);
        }
    }
}

 
