using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    Animator anim;

    public Transform player;
    public float agroRange;
    public float moveSpeed;

    Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);

        if (distToPlayer < agroRange)
        {
            chasePlayer();
        }

        else
        {
            StopChasingPlayer();
        }
    }

     void chasePlayer()
    {
        if (transform.position.x < player.position.x) 
        {
            rb2d.velocity = new Vector2(moveSpeed, 0);
           
        }
        else 
        {
            rb2d.velocity = new Vector2(-moveSpeed, 0);
            
        }
        anim.Play("PBear_RunAN");
    }

    void StopChasingPlayer()
    {
        rb2d.velocity = new Vector2(0, 0);
    }
}


