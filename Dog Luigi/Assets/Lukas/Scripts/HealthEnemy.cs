using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    
   
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BOX"))
        {
            Destroy(this.gameObject);
        }
    }

}
