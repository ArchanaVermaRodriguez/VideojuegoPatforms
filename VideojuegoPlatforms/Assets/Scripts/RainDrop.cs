using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDrop : MonoBehaviour
{
      public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      gameObject.transform.Translate(new Vector2(0, -1*Speed));
    }

    
    void OnCollisionEnter2D(Collision2D other){

        Debug.Log(other.gameObject.name);
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other){

       if(other.tag == "Player"){
           GameControl.Health-=1;
           Destroy(gameObject);
        }

         if(other.tag == "Platform"){
            Destroy(gameObject);
         }
        
    }
}