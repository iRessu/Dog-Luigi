using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class Test : MonoBehaviour
{
    public UnityEvent happens;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BOX"))
        {
            Destroy(this.gameObject);
            happens.Invoke();

        }
       
    }
}
