using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    float Hitpoints;
    public float MaxHitpoints = 1;
    // Start is called before the first frame update
    void Start()
    {
        Hitpoints = MaxHitpoints;
    }

    

    public void TakeHit(float Damage)
    {
        Hitpoints -= Damage;
        if (Hitpoints<=0)
        { 
            Destroy(gameObject);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<EnemyAgro>();
        if (enemy)
        {
            
        }
    }
}
