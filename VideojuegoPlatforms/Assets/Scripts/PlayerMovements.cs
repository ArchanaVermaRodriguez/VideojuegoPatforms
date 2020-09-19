using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovements : MonoBehaviour
{



    [Header ("Movement")]
    public float Speed;
    public float jumpForce;
    public float moveInput;
    public static int direction=1;
    private float originalXScale;
    public float xVelocity;
    private bool moving;

    [Header("Unity Components")]
    public Rigidbody2D fisicas;

    [Header("Jump")]
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadious;
    public LayerMask whatIsGround;
    private int extraJumps=1;// de aquí se resta el valor de extraJumpsValues
    public int extraJumpsValue=2;// valor de los saltos extras 
  
    [Header("Poder")]
    private float boostTimer;
    private bool boosting;

    
    public Vector3 startPosition;


    private Rigidbody2D rb;
 
    void Start()
    {
        
        moving = false;
        extraJumps= extraJumpsValue;
        rb= GetComponent<Rigidbody2D>();
        fisicas= GetComponent<Rigidbody2D>();    
        originalXScale = transform.localScale.x;
        boostTimer = 0;
        boosting = false;

        

        SaveCheckpoint();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded=Physics2D.OverlapCircle(groundCheck.position, checkRadious, whatIsGround);

        moveInput=Input.GetAxis("Horizontal");
        xVelocity= Speed*moveInput;
        fisicas.velocity= new Vector2(xVelocity, fisicas.velocity.y);    
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Poder"){
            boosting = true;
            Destroy(other.gameObject);
            Speed = 25;
        }
         if(other.tag == "Masks"){
             Destroy(other.gameObject);
         }
        
         if(other.tag =="Edge"){
           
            Restart();
         }
          if(other.tag =="Sneeze"){
             
         }
        
    }

    void Update(){
        if(isGrounded){
            extraJumps=extraJumpsValue;
        }

        if(Input.GetKeyDown(KeyCode.UpArrow) && isGrounded){
            rb.velocity= Vector2.up*jumpForce;
            extraJumps--;
        }

        if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps>0){
            rb.velocity= Vector2.up*jumpForce;
            extraJumps--;
        } 

        if(moving){
            this.transform.Translate(new Vector3(Time.deltaTime * Speed, 0, 0));
        }

        if(boosting){
            boostTimer += Time.deltaTime;
            if(boostTimer >= 3){
                Speed = 5;
                boostTimer = 0;
                boosting = false;
            }
        }



    }


  private void SaveCheckpoint(){
        startPosition = gameObject.transform.position;
    }

    private void Restart(){
        gameObject.transform.position = startPosition;
    }

}