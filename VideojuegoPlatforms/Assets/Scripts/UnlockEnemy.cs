using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockEnemy : MonoBehaviour
{
    public GameObject Enemy, TextWinner;

    // Start is called before the first frame update
    void Start()
    {
        Enemy.gameObject.SetActive(false);
        TextWinner.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


       void OnTriggerEnter2D(Collider2D other){

        if(other.tag == "Player"){
           Enemy.gameObject.SetActive(true);
           Destroy(gameObject);
        }
    }
}
