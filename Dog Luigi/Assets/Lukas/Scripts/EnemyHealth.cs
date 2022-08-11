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

            var enemy = Collision.collider.GetComponent<EnemyAgro>();
            Destroy(gameObject);
        }
    }
}
