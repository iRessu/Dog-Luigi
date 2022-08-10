using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
   public Transform endPoint;

    Transform thisTransform;

    public bool go = false;

    public float timeToMove;

    private void Start()
    {
        thisTransform = this.gameObject.transform;
    }

    private void FixedUpdate()
    {
        if(go == true)
        {
            Vector3 a = thisTransform.position;
            Vector3 b = endPoint.position;
            thisTransform.position = Vector3.Lerp(a, b, timeToMove);
        }
       
    }


    public void MovePlatformUp()
    {
        go = true;
    }
    
}
