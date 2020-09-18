using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameObject Heart1, Heart2, Heart3, GameOver, Heart;

    

    public static int Health;

    // Start is called before the first frame update
    void Start()
    {
       Health = 3;
       Heart1.gameObject.SetActive(true);
       Heart2.gameObject.SetActive(true);
       Heart3.gameObject.SetActive(true);

       GameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if(Health>3){
           Health=3;

       } 

       switch(Health){
           case 3:
           Heart1.gameObject.SetActive(true);
           Heart2.gameObject.SetActive(true);
           Heart3.gameObject.SetActive(true);
           Heart.gameObject.SetActive(false);
           break;

           case 2:
           Heart1.gameObject.SetActive(true);
           Heart2.gameObject.SetActive(true);
           Heart3.gameObject.SetActive(false);
           Heart.gameObject.SetActive(true);
           break;

           case 1:
           Heart1.gameObject.SetActive(true);
           Heart2.gameObject.SetActive(false);
           Heart3.gameObject.SetActive(false);
           break;

           case 0:
           Heart1.gameObject.SetActive(false);
           Heart2.gameObject.SetActive(false);
           Heart3.gameObject.SetActive(false);

           GameOver.gameObject.SetActive(true);

           Time.timeScale = 0;

           break;
       }
    }
}
