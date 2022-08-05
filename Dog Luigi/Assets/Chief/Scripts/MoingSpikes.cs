using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoingSpikes : MonoBehaviour
{

    private Transform tar;
    public bool first = false;
    public bool flynow = false;
   

    [SerializeField] float movingSpeed;
    
   
    void Start()
    {
        tar = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        if (first == true)
        {
            MoveRight();
            Invoke("flynowbool", 2);
        }
        if(first == false && flynow == true)
        {
            fly();
            Destroy(this.gameObject, 2);
        }
      
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            first = true;
        }  
        
    }

     void MoveRight()
    {
        tar.Translate(new Vector2(3 * movingSpeed * Time.deltaTime, 0));
        
    }
    void flynowbool()
    {
        flynow = true;
        first = false;
    }

    void fly()
    {       
        tar.Translate(new Vector2(0, 20 * Time.deltaTime));
    }


   
}
