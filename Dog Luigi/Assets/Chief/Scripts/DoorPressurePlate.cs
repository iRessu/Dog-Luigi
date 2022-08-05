using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPressurePlate : MonoBehaviour
{
    [SerializeField] private GameObject doorGameObject;
    private  DoorFunctions door; 
    private float timer;
    private void Awake ()
    {
        door = doorGameObject.GetComponent<DoorFunctions>();
    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                door.CloseDoor();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<PlayerMovement>() != null)
        {
            //Player entered collider
            door.OpenDoor();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Player still on top of collider
        timer = 1f;
    }
}
