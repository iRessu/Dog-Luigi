using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxBG : MonoBehaviour
{

    public float moveSpeed;
    public float offSet;


    private Vector2 startPosition;
    private float newXposition;

    void Start()
    {
        startPosition = transform.position;   
    }

    
    void Update()
    {
        newXposition = Mathf.Repeat(Time.time * -moveSpeed, offSet);

        transform.position = startPosition + Vector2.right * newXposition;
    }
}
