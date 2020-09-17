using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float lifeTime = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
       Awake(); 
    }

    // Update is called once per frame
    void Update()
    {
       gameObject.transform.Translate(new Vector2(1f,0)); 
    }

       //reportar cuando haya una colision con el object al cual se le está adjuntando el script
    void OnCollisionEnter2D(Collision2D other){
    
    //Buscar si este componente tiene el componente de tipo Asteroid estamos hablando del del script 
    if(other.gameObject.GetComponent<Enemy>()){
        other.gameObject.GetComponent<Enemy>().DealDamage();
        Debug.Log(other.gameObject.name);
        Destroy(gameObject);
       
    }else if(other.gameObject.GetComponent<SneezeDrops>()){
        Debug.Log(other.gameObject.name);
        Destroy(gameObject);
    }

    }

    void Awake () { Destroy (gameObject, lifeTime); }
}
