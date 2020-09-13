using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{


    [Header ("Movement")]
    public float Speed;
    public float jumpForce;
    public float moveInput;
    public float xVelocity;

    [Header("Unity Components")]
    public Rigidbody2D fisicas;

    [Header("Jump")]
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadious;
    public LayerMask whatIsGround;
    private int extraJumps=1;// de aquí se resta el valor de extraJumpsValues
    public int extraJumpsValue=1;// valor de los saltos extras 
  

    private Rigidbody2D rb;
 
    void Start()
    {
        extraJumps= extraJumpsValue;
        rb= GetComponent<Rigidbody2D>();
        fisicas= GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded=Physics2D.OverlapCircle(groundCheck.position, checkRadious, whatIsGround);

        moveInput=Input.GetAxis("Horizontal");
        xVelocity= Speed*moveInput;
        fisicas.velocity= new Vector2(xVelocity, fisicas.velocity.y);    
        
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

    }



}
