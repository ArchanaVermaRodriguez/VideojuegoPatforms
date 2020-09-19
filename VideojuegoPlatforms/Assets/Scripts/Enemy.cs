using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Gun;

    public int Life;

    public GameObject Bullet;


    public Transform Player;

    public float Range;

    public float moveSpeed;

    public GameObject WinnerText;

    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        InvokeRepeating("Shoot", 0,1.5f); 
        WinnerText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //ditance between player
        float distToPlayer = Vector2.Distance(transform.position, Player.position);
        print("distToPlayer:"+distToPlayer);

        if(distToPlayer < Range){
            //what chases the player
            ChasePlayer();
        }
        else{
            // what stops chasing the player
            StopChasingPlayer();
        }

        if( Life <= 0 ){
            Destroy(gameObject);
            WinnerText.gameObject.SetActive(true);
            
        } 
       
    }

    void Shoot(){
        Instantiate(Bullet, Gun.transform.position, Quaternion.identity);
    }

    public void DealDamage(){
        Life--;
    }

    void ChasePlayer(){
        if(transform.position.x < Player.position.x){
            //we are on the left of the player and we want to move right 
            rb2d.velocity = new Vector2(moveSpeed, 0);
          
        }
        else {
            //we are on the right of the player and we want to move left 
            rb2d.velocity = new Vector2(-moveSpeed, 0);
         
        }
    
    }

    void StopChasingPlayer(){
        rb2d.velocity = new Vector2(0,0);
    }


}
